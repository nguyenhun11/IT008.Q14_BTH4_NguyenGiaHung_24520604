using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace Bai6
{
    public partial class CopyFile : Form
    {
        string sourcePath = "";
        string destinationPath = "";

        // Biến để tính toán Progress Bar
        long totalSize = 0;
        long totalCopied = 0;

        BackgroundWorker worker = new BackgroundWorker();

        public CopyFile()
        {
            InitializeComponent();

            worker.WorkerReportsProgress = true;
            worker.WorkerSupportsCancellation = true;

            worker.DoWork += Worker_DoWork;
            worker.ProgressChanged += Worker_ProgressChanged;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
        }

        // 1. Chọn Folder Nguồn (Dùng FolderBrowserDialog)
        private void buttonSource_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Thư mục nguồn";

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                sourcePath = fbd.SelectedPath;
                textBoxSource.Text = sourcePath;
            }
        }

        // 2. Chọn Folder Đích
        private void buttonDes_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Thư mục đích";

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                destinationPath = fbd.SelectedPath;
                textBoxDes.Text = destinationPath;
            }
        }

        // 3. Nút Copy
        private void buttonCopy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(sourcePath) || string.IsNullOrEmpty(destinationPath))
            {
                MessageBox.Show("Vui lòng chọn đủ đường dẫn!");
                return;
            }

            // Tạo thư mục đích mới (Ví dụ: Copy "Data" vào "D:\" -> tạo "D:\Data")
            string folderName = new DirectoryInfo(sourcePath).Name;
            string finalDest = Path.Combine(destinationPath, folderName);

            // Kiểm tra tránh copy lồng nhau (Source nằm trong Dest)
            if (finalDest.StartsWith(sourcePath))
            {
                MessageBox.Show("Thư mục đích không được nằm bên trong thư mục nguồn!");
                return;
            }

            buttonCopy.Enabled = false;
            progressBar1.Value = 0;

            // Truyền đường dẫn đích cuối cùng vào Worker
            worker.RunWorkerAsync(finalDest);
        }

        // --- LOGIC XỬ LÝ (OS Principles) ---

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            string finalDestDir = (string)e.Argument;

            // Bước 1: Tính tổng dung lượng thư mục nguồn (để chia % cho chuẩn)
            totalSize = CalculateDirSize(sourcePath);
            totalCopied = 0;

            // Bước 2: Bắt đầu Copy đệ quy
            CopyDirectoryRecursive(sourcePath, finalDestDir);
        }

        // Hàm Đệ quy: Copy thư mục và toàn bộ nội dung con
        private void CopyDirectoryRecursive(string sourceDir, string destDir)
        {
            // 1. Tạo thư mục đích nếu chưa có
            Directory.CreateDirectory(destDir);

            // 2. Lấy danh sách File và copy
            string[] files = Directory.GetFiles(sourceDir);
            foreach (string file in files)
            {
                string name = Path.GetFileName(file);
                string destFile = Path.Combine(destDir, name);

                // Gọi hàm copy file từng chút một (Stream)
                CopySingleFile(file, destFile);
            }

            // 3. ĐỆ QUY: Lấy danh sách Thư mục con và gọi lại chính hàm này
            string[] dirs = Directory.GetDirectories(sourceDir);
            foreach (string dir in dirs)
            {
                string name = new DirectoryInfo(dir).Name;
                string destSubDir = Path.Combine(destDir, name);

                // Gọi đệ quy đi sâu vào thư mục con
                CopyDirectoryRecursive(dir, destSubDir);
            }
        }

        // Hàm copy 1 file (dùng Stream để update progress bar mượt)
        private void CopySingleFile(string source, string dest)
        {
            byte[] buffer = new byte[1024 * 1024]; // Buffer 1MB
            int bytesRead;

            using (FileStream fsSource = new FileStream(source, FileMode.Open, FileAccess.Read))
            using (FileStream fsDest = new FileStream(dest, FileMode.Create, FileAccess.Write))
            {
                while ((bytesRead = fsSource.Read(buffer, 0, buffer.Length)) > 0)
                {
                    fsDest.Write(buffer, 0, bytesRead);

                    // Cộng dồn vào biến toàn cục
                    totalCopied += bytesRead;

                    // Tính % dựa trên TỔNG dung lượng cả thư mục
                    if (totalSize > 0)
                    {
                        int percent = (int)((double)totalCopied / totalSize * 100);
                        worker.ReportProgress(percent, source);
                    }
                }
            }
        }

        // Hàm phụ: Tính tổng dung lượng thư mục (để làm mẫu số cho Progress Bar)
        private long CalculateDirSize(string path)
        {
            long size = 0;

            // Cộng dung lượng file
            string[] files = Directory.GetFiles(path);
            foreach (string file in files)
            {
                FileInfo info = new FileInfo(file);
                size += info.Length;
            }

            // Cộng dung lượng thư mục con (Đệ quy)
            string[] dirs = Directory.GetDirectories(path);
            foreach (string dir in dirs)
            {
                size += CalculateDirSize(dir);
            }

            return size;
        }

        private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Cập nhật UI chỉ khi % thay đổi để tránh lag
            if (e.ProgressPercentage > progressBar1.Value)
            {
                progressBar1.Value = Math.Min(e.ProgressPercentage, 100);
            }

            string currentFile = e.UserState as string;

            if (currentFile != null)
            {
                // Bạn có thể chọn hiển thị Full đường dẫn hoặc chỉ Tên file

                // Cách 1: Hiển thị full đường dẫn (C:\Folder\File.txt)
                toolStripStatusLabel.Text = $"Đang sao chép: {currentFile}";

                // Cách 2: Chỉ hiển thị tên file cho gọn (File.txt) -> Khuyên dùng nếu đường dẫn quá dài
                // toolStripStatusLabel1.Text = $"Đang sao chép: {Path.GetFileName(currentFile)}";
            }
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            buttonCopy.Enabled = true;
            progressBar1.Value = 100;
            toolStripStatusLabel.Text = "Đã hoàn tất sao chép.";

            if (e.Error != null) MessageBox.Show("Lỗi: " + e.Error.Message);
            else MessageBox.Show("Sao chép thư mục hoàn tất!");
        }
    }
}
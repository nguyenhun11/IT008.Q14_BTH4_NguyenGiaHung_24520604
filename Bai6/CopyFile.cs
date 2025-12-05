using System.ComponentModel;

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

            // Cấu hình giao diện ban đầu
            textBoxSource.ReadOnly = true;
            textBoxDes.ReadOnly = true;
            toolStripStatusLabel.Text = "";

            // Cấu hình Worker
            worker.WorkerReportsProgress = true;
            worker.WorkerSupportsCancellation = true;

            worker.DoWork += Worker_DoWork;
            worker.ProgressChanged += Worker_ProgressChanged;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;

            // Cấu hình Tooltip
            toolTip1.SetToolTip(buttonSource, "Chọn thư mục nguồn");
            toolTip1.SetToolTip(buttonDes, "Chọn thư mục đích");
            toolTip1.SetToolTip(textBoxSource, "Đường dẫn thư mục nguồn");
            toolTip1.SetToolTip(textBoxDes, "Đường dẫn thư mục đích");
            toolTip1.SetToolTip(buttonCopy, "Bắt đầu sao chép thư mục");
            toolTip1.SetToolTip(progressBar1, "Tiến trình sao chép");
        }

        // 1. Chọn Folder Nguồn
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

        // 3. Nút Copy (Đã cập nhật logic đổi tên trùng)
        private void buttonCopy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(sourcePath) || string.IsNullOrEmpty(destinationPath))
            {
                MessageBox.Show("Vui lòng chọn đủ đường dẫn!");
                return;
            }
            if (!Directory.Exists(sourcePath))
            {
                MessageBox.Show($"Thư mục nguồn không tồn tại hoặc đã bị đổi tên!\nĐường dẫn cũ: {sourcePath}\nVui lòng chọn lại.", "Lỗi đường dẫn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Directory.Exists(destinationPath))
            {
                MessageBox.Show($"Thư mục đích không tồn tại hoặc đã bị xóa!\nĐường dẫn cũ: {destinationPath}\nVui lòng chọn lại.", "Lỗi đường dẫn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Lấy tên thư mục gốc (Ví dụ: "Data")
            string folderName = new DirectoryInfo(sourcePath).Name;
            string finalDest = Path.Combine(destinationPath, folderName);

            int count = 1;
            while (Directory.Exists(finalDest))
            {
                // Nếu trùng, tạo tên mới: "Data (1)", "Data (2)"...
                string newName = $"{folderName} ({count})";
                finalDest = Path.Combine(destinationPath, newName);
                count++;
            }
            // Kết thúc vòng lặp này, finalDest sẽ là một đường dẫn duy nhất chưa tồn tại

            // Kiểm tra tránh copy lồng nhau (Source nằm trong Dest)
            // Lưu ý: finalDest lúc này có thể là "Data (1)", vẫn phải check
            if (finalDest.StartsWith(sourcePath))
            {
                MessageBox.Show("Thư mục đích không được nằm bên trong thư mục nguồn!");
                return;
            }

            buttonCopy.Enabled = false;
            progressBar1.Value = 0;

            // Truyền đường dẫn đích (đã được xử lý trùng tên) vào Worker
            worker.RunWorkerAsync(finalDest);
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            string finalDestDir = (string)e.Argument;

            if (!Directory.Exists(sourcePath))
            {
                throw new DirectoryNotFoundException("Thư mục nguồn đã bị mất hoặc đổi tên trong quá trình xử lý.");
            }

            //Tính tổng dung lượng thư mục nguồn
            totalSize = CalculateDirSize(sourcePath);
            totalCopied = 0;

            //Bắt đầu Copy đệ quy
            CopyDirectoryRecursive(sourcePath, finalDestDir);
        }

        // Hàm Đệ quy: Copy thư mục và toàn bộ nội dung con
        private void CopyDirectoryRecursive(string sourceDir, string destDir)
        {
            if (!Directory.Exists(sourcePath))
            {
                throw new DirectoryNotFoundException("Thư mục nguồn đã bị mất hoặc đổi tên trong quá trình xử lý.");
            }
            // 1. Tạo thư mục đích
            Directory.CreateDirectory(destDir);

            // 2. Lấy danh sách File và copy
            string[] files = Directory.GetFiles(sourceDir);
            foreach (string file in files)
            {
                string name = Path.GetFileName(file);
                string destFile = Path.Combine(destDir, name);
                CopySingleFile(file, destFile);
            }

            // 3. ĐỆ QUY: Lấy danh sách Thư mục con
            string[] dirs = Directory.GetDirectories(sourceDir);
            foreach (string dir in dirs)
            {
                string name = new DirectoryInfo(dir).Name;
                string destSubDir = Path.Combine(destDir, name);
                CopyDirectoryRecursive(dir, destSubDir);
            }
        }

        // Hàm copy 1 file
        private void CopySingleFile(string source, string dest)
        {
            byte[] buffer = new byte[1024 * 1024]; // Buffer 1MB
            int bytesRead;

            if (totalSize > 0)
            {
                int percent = (int)((double)totalCopied / totalSize * 100);
                worker.ReportProgress(percent, source);
            }

            using (FileStream fsSource = new FileStream(source, FileMode.Open, FileAccess.Read))
            using (FileStream fsDest = new FileStream(dest, FileMode.Create, FileAccess.Write))
            {
                while ((bytesRead = fsSource.Read(buffer, 0, buffer.Length)) > 0)
                {
                    fsDest.Write(buffer, 0, bytesRead);
                    totalCopied += bytesRead;

                    if (totalSize > 0)
                    {
                        int percent = (int)((double)totalCopied / totalSize * 100);
                        worker.ReportProgress(percent, source);
                    }
                }
            }
        }

        // Hàm tính tổng dung lượng
        private long CalculateDirSize(string path)
        {
            long size = 0;
            try
            {
                string[] files = Directory.GetFiles(path);
                foreach (string file in files)
                {
                    FileInfo info = new FileInfo(file);
                    size += info.Length;
                }

                string[] dirs = Directory.GetDirectories(path);
                foreach (string dir in dirs)
                {
                    size += CalculateDirSize(dir);
                }
            }
            catch { } // Bỏ qua lỗi truy cập nếu có file hệ thống
            return size;
        }

        private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage > progressBar1.Value)
            {
                progressBar1.Value = Math.Min(e.ProgressPercentage, 100);
            }

            string currentFile = e.UserState as string;

            if (currentFile != null)
            {
                string fileName = Path.GetFileName(currentFile);
                string statusMessage = $"Đang sao chép: {fileName}";

                toolStripStatusLabel.Text = statusMessage;
                toolTip1.SetToolTip(progressBar1, statusMessage);
            }
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            buttonCopy.Enabled = true;
            progressBar1.Value = 100;
            toolStripStatusLabel.Text = "Đã hoàn tất sao chép.";
            toolTip1.SetToolTip(progressBar1, "Sao chép hoàn tất.");

            if (e.Error != null) MessageBox.Show("Lỗi: " + e.Error.Message);
            else
            {
                MessageBox.Show("Sao chép thư mục hoàn tất!");
                progressBar1.Value = 0;
                toolTip1.SetToolTip(progressBar1, "Tiến trình sao chép");
            }
        }
    }
}
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Bai4
{
    public partial class TextEditor : Form
    {
        static string textFile = "";
        static bool isOpen = false;

        public TextEditor()
        {
            InitializeComponent();
            InitializeCombobox();
        }

        private void InitializeCombobox()
        {
            foreach (FontFamily font in System.Drawing.FontFamily.Families)
            {
                toolStripComboBoxFont.Items.Add(font.Name);
            }
            for (int i = 5; i < 72; i++)
            {
                toolStripComboBoxSize.Items.Add(i);
            }

            // Đã bỏ comment và sẽ chạy tốt sau khi sửa hàm changeFontStyle bên dưới
            toolStripComboBoxFont.Text = "Tahoma";
            toolStripComboBoxSize.Text = "12";
        }

        private void formatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontdialog = new FontDialog();
            fontdialog.ShowColor = true;
            fontdialog.ShowApply = true;
            fontdialog.ShowEffects = true;
            fontdialog.ShowHelp = true;
            if (fontdialog.ShowDialog() == DialogResult.OK)
            {
                // SỬA: Chỉ áp dụng cho vùng chọn thay vì toàn bộ văn bản
                richTextBox.SelectionFont = fontdialog.Font;
                richTextBox.SelectionColor = fontdialog.Color; // Áp dụng cả màu nếu chọn
            }
        }

        private void changeFontStyle(object sender, EventArgs e)
        {
            try
            {
                string fontName = toolStripComboBoxFont.Text;
                string fontSizeStr = toolStripComboBoxSize.Text;

                // Kiểm tra dữ liệu hợp lệ trước khi tạo Font
                if (!string.IsNullOrEmpty(fontName) && !string.IsNullOrEmpty(fontSizeStr))
                {
                    float fontSize = float.Parse(fontSizeStr);

                    // SỬA LỖI TẠI ĐÂY:
                    // 1. Lấy style hiện tại của vùng chọn (Bold, Italic...) để giữ nguyên
                    FontStyle currentStyle = FontStyle.Regular;
                    if (richTextBox.SelectionFont != null)
                    {
                        currentStyle = richTextBox.SelectionFont.Style;
                    }

                    // 2. Tạo font mới với Font Family, Size mới nhưng giữ Style cũ
                    // 3. Gán vào SelectionFont thay vì Font (Font sẽ đổi cả bài)
                    richTextBox.SelectionFont = new Font(fontName, fontSize, currentStyle);
                }
            }
            catch (Exception)
            {
                // Bỏ qua lỗi nếu font chưa load xong hoặc font không hỗ trợ style hiện tại
            }
        }

        private void toolStripButtonBold_Click(object sender, EventArgs e)
        {
            if (richTextBox.SelectionFont != null)
            {
                Font font = richTextBox.SelectionFont;
                FontStyle fs = font.Style; // Lấy style hiện tại ngắn gọn hơn

                if (font.Bold)
                    fs &= ~FontStyle.Bold; // Bỏ Bold
                else
                    fs |= FontStyle.Bold;  // Thêm Bold

                richTextBox.SelectionFont = new Font(font.FontFamily, font.Size, fs);
            }
        }

        private void toolStripButtonItalic_Click(object sender, EventArgs e)
        {
            if (richTextBox.SelectionFont != null)
            {
                Font font = richTextBox.SelectionFont;
                FontStyle fs = font.Style;

                if (font.Italic)
                    fs &= ~FontStyle.Italic;
                else
                    fs |= FontStyle.Italic;

                richTextBox.SelectionFont = new Font(font.FontFamily, font.Size, fs);
            }
        }

        private void toolStripButtonUnderline_Click(object sender, EventArgs e)
        {
            if (richTextBox.SelectionFont != null)
            {
                Font font = richTextBox.SelectionFont;
                FontStyle fs = font.Style;

                if (font.Underline)
                    fs &= ~FontStyle.Underline;
                else
                    fs |= FontStyle.Underline;

                richTextBox.SelectionFont = new Font(font.FontFamily, font.Size, fs);
            }
        }

        private void toolStripButtonNew_Click(object sender, EventArgs e)
        {
            if (richTextBox.Text != "")
            {
                DialogResult dr = MessageBox.Show("Bạn có muốn lưu các thay đổi?", "Các thay đổi chưa được lưu lại", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        if (isOpen)
                            toolStripButtonSave_Click(sender, e);
                        else SaveAs();
                        break;
                    case DialogResult.No:
                        break;
                }
            }
            this.Text = "Untittled.txt";
            richTextBox.Text = "";
            toolStripComboBoxFont.Text = "Tahoma";
            toolStripComboBoxSize.Text = "14";
            isOpen = false;
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            if (textFile == "")
                SaveAs();
            else
            {
                // Dùng StreamWriter với Text để tránh lỗi font chữ tiếng Việt
                using (StreamWriter sw = new StreamWriter(textFile))
                {
                    sw.Write(richTextBox.Text);
                }
            }
        }

        private void SaveAs()
        {
            SaveFileDialog saveTextFile = new SaveFileDialog();
            saveTextFile.Filter = "Text file (*.txt)|*.txt|Document file (*.doc)|*.doc|All files (*.*)|*.*";
            if (saveTextFile.ShowDialog() == DialogResult.OK)
            {
                textFile = saveTextFile.FileName; // Cập nhật đường dẫn file hiện tại
                isOpen = true;
                this.Text = textFile;

                using (StreamWriter s = new StreamWriter(textFile))
                {
                    s.Write(richTextBox.Text);
                }
            }
        }

        //System menu strip event handlers

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButtonNew_Click(sender, e);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButtonSave_Click(sender, e);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openTextFile = new OpenFileDialog();
            openTextFile.Filter = "Text file (*.txt)|*.txt|Document file (*.doc)|*.doc|All files (*.*)|*.*";
            if (openTextFile.ShowDialog() == DialogResult.OK)
            {
                if (richTextBox.Text != "")
                {
                    DialogResult dr = MessageBox.Show("Bạn có muốn lưu các thay đổi của tệp tin cũ?", "Các thay đổi chưa được lưu lại", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        if (isOpen)
                            toolStripButtonSave_Click(sender, e);
                        else SaveAs();
                    }
                }

                textFile = openTextFile.FileName;
                this.Text = textFile;
                isOpen = true;

                // Đọc file
                try
                {
                    richTextBox.Text = File.ReadAllText(textFile);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi đọc file: " + ex.Message);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox.Text != "")
            {
                DialogResult dr = MessageBox.Show("Bạn có muốn lưu các thay đổi?", "Thoát", MessageBoxButtons.YesNoCancel);
                if (dr == DialogResult.Yes)
                {
                    toolStripButtonSave_Click(sender, e);
                    Application.Exit();
                }
                else if (dr == DialogResult.No)
                {
                    Application.Exit();
                }
                // Cancel thì không làm gì cả
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
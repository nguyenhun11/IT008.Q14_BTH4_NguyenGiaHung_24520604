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


        bool isUpdatingUI = false;

        public TextEditor()
        {
            InitializeComponent();
            InitializeCombobox();
            richTextBox.SelectionChanged += new EventHandler(richTextBox_SelectionChanged);
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

            toolStripComboBoxFont.Text = "Tahoma";
            toolStripComboBoxSize.Text = "14";
        }

        private void richTextBox_SelectionChanged(object sender, EventArgs e)
        {
            isUpdatingUI = true;

            try
            {
                if (richTextBox.SelectionFont != null)
                {
                    toolStripComboBoxFont.Text = richTextBox.SelectionFont.Name;
                    toolStripComboBoxSize.Text = ((int)richTextBox.SelectionFont.Size).ToString();

                    toolStripButtonBold.Checked = richTextBox.SelectionFont.Bold;
                    toolStripButtonItalic.Checked = richTextBox.SelectionFont.Italic;
                    toolStripButtonUnderline.Checked = richTextBox.SelectionFont.Underline;
                }
                else
                {
                    toolStripComboBoxFont.Text = "";
                    toolStripComboBoxSize.Text = "";
                    toolStripButtonBold.Checked = false;
                    toolStripButtonItalic.Checked = false;
                    toolStripButtonUnderline.Checked = false;
                }
            }
            finally
            {
                isUpdatingUI = false;
            }
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
                richTextBox.SelectionFont = fontdialog.Font;
                richTextBox.SelectionColor = fontdialog.Color;
            }
        }

        private void changeFontStyle(object sender, EventArgs e)
        {
            if (isUpdatingUI) return;

            try
            {
                string fontName = toolStripComboBoxFont.Text;
                string fontSizeStr = toolStripComboBoxSize.Text;

                if (!string.IsNullOrEmpty(fontName) && !string.IsNullOrEmpty(fontSizeStr))
                {
                    float fontSize = float.Parse(fontSizeStr);

                    FontStyle currentStyle = FontStyle.Regular;
                    if (richTextBox.SelectionFont != null)
                    {
                        currentStyle = richTextBox.SelectionFont.Style;
                    }

                    richTextBox.SelectionFont = new Font(fontName, fontSize, currentStyle);
                }
            }
            catch
            {
                return;
            }
        }

        private void toolStripButtonBold_Click(object sender, EventArgs e)
        {
            if (richTextBox.SelectionFont != null)
            {
                Font font = richTextBox.SelectionFont;
                FontStyle fs = font.Style;

                if (font.Bold)
                    fs &= ~FontStyle.Bold;
                else
                    fs |= FontStyle.Bold;

                richTextBox.SelectionFont = new Font(font.FontFamily, font.Size, fs);

                toolStripButtonBold.Checked = !toolStripButtonBold.Checked;
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

                toolStripButtonItalic.Checked = !toolStripButtonItalic.Checked;
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

                toolStripButtonUnderline.Checked = !toolStripButtonUnderline.Checked;
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
                textFile = saveTextFile.FileName;
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
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
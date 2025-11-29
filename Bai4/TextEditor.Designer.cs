namespace Bai4
{
    partial class TextEditor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextEditor));
            menuStrip1 = new MenuStrip();
            systemToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            saveToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            formatToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripButtonNew = new ToolStripButton();
            toolStripButtonSave = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripComboBoxFont = new ToolStripComboBox();
            toolStripComboBoxSize = new ToolStripComboBox();
            toolStripButtonBold = new ToolStripButton();
            toolStripButtonItalic = new ToolStripButton();
            toolStripButtonUnderline = new ToolStripButton();
            labelTitle = new Label();
            richTextBox = new RichTextBox();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.SlateGray;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { systemToolStripMenuItem, formatToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // systemToolStripMenuItem
            // 
            systemToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, toolStripSeparator2, saveToolStripMenuItem, exitToolStripMenuItem });
            systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            systemToolStripMenuItem.Size = new Size(85, 24);
            systemToolStripMenuItem.Text = "Hệ thống";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Image = (Image)resources.GetObject("newToolStripMenuItem.Image");
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newToolStripMenuItem.Size = new Size(285, 26);
            newToolStripMenuItem.Text = "Tạo văn bản mới ";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Image = (Image)resources.GetObject("openToolStripMenuItem.Image");
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(285, 26);
            openToolStripMenuItem.Text = "Mở tập tin";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(282, 6);
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Image = (Image)resources.GetObject("saveToolStripMenuItem.Image");
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(285, 26);
            saveToolStripMenuItem.Text = "Lưu nội dung văn bản";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(285, 26);
            exitToolStripMenuItem.Text = "Thoát";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // formatToolStripMenuItem
            // 
            formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            formatToolStripMenuItem.Size = new Size(92, 24);
            formatToolStripMenuItem.Text = "&Định dạng";
            formatToolStripMenuItem.Click += formatToolStripMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.LightSlateGray;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButtonNew, toolStripButtonSave, toolStripSeparator1, toolStripComboBoxFont, toolStripComboBoxSize, toolStripButtonBold, toolStripButtonItalic, toolStripButtonUnderline });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.System;
            toolStrip1.Size = new Size(800, 28);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonNew
            // 
            toolStripButtonNew.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonNew.Image = (Image)resources.GetObject("toolStripButtonNew.Image");
            toolStripButtonNew.ImageTransparentColor = Color.Magenta;
            toolStripButtonNew.Name = "toolStripButtonNew";
            toolStripButtonNew.Size = new Size(29, 25);
            toolStripButtonNew.Text = "toolStripButton1";
            toolStripButtonNew.Click += toolStripButtonNew_Click;
            // 
            // toolStripButtonSave
            // 
            toolStripButtonSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonSave.Image = (Image)resources.GetObject("toolStripButtonSave.Image");
            toolStripButtonSave.ImageTransparentColor = Color.Magenta;
            toolStripButtonSave.Name = "toolStripButtonSave";
            toolStripButtonSave.Size = new Size(29, 25);
            toolStripButtonSave.Text = "toolStripButton2";
            toolStripButtonSave.Click += toolStripButtonSave_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 28);
            // 
            // toolStripComboBoxFont
            // 
            toolStripComboBoxFont.Name = "toolStripComboBoxFont";
            toolStripComboBoxFont.Size = new Size(121, 28);
            toolStripComboBoxFont.TextChanged += changeFontStyle;
            // 
            // toolStripComboBoxSize
            // 
            toolStripComboBoxSize.Name = "toolStripComboBoxSize";
            toolStripComboBoxSize.Size = new Size(80, 28);
            toolStripComboBoxSize.OwnerChanged += changeFontStyle;
            toolStripComboBoxSize.TextChanged += changeFontStyle;
            // 
            // toolStripButtonBold
            // 
            toolStripButtonBold.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonBold.Image = (Image)resources.GetObject("toolStripButtonBold.Image");
            toolStripButtonBold.ImageTransparentColor = Color.Magenta;
            toolStripButtonBold.Name = "toolStripButtonBold";
            toolStripButtonBold.Size = new Size(29, 25);
            toolStripButtonBold.Text = "toolStripButton1";
            toolStripButtonBold.Click += toolStripButtonBold_Click;
            // 
            // toolStripButtonItalic
            // 
            toolStripButtonItalic.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonItalic.Image = (Image)resources.GetObject("toolStripButtonItalic.Image");
            toolStripButtonItalic.ImageTransparentColor = Color.Magenta;
            toolStripButtonItalic.Name = "toolStripButtonItalic";
            toolStripButtonItalic.Size = new Size(29, 25);
            toolStripButtonItalic.Text = "toolStripButton1";
            toolStripButtonItalic.Click += toolStripButtonItalic_Click;
            // 
            // toolStripButtonUnderline
            // 
            toolStripButtonUnderline.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonUnderline.Image = (Image)resources.GetObject("toolStripButtonUnderline.Image");
            toolStripButtonUnderline.ImageTransparentColor = Color.Magenta;
            toolStripButtonUnderline.Name = "toolStripButtonUnderline";
            toolStripButtonUnderline.Size = new Size(29, 25);
            toolStripButtonUnderline.Text = "toolStripButton1";
            toolStripButtonUnderline.Click += toolStripButtonUnderline_Click;
            // 
            // labelTitle
            // 
            labelTitle.BackColor = Color.LightSteelBlue;
            labelTitle.Dock = DockStyle.Top;
            labelTitle.Font = new Font("Segoe UI Black", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.Location = new Point(0, 56);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(800, 60);
            labelTitle.TabIndex = 3;
            labelTitle.Text = "Trình soạn thảo văn bản";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // richTextBox
            // 
            richTextBox.BorderStyle = BorderStyle.None;
            richTextBox.Dock = DockStyle.Fill;
            richTextBox.Location = new Point(0, 116);
            richTextBox.Name = "richTextBox";
            richTextBox.Size = new Size(800, 334);
            richTextBox.TabIndex = 4;
            richTextBox.Text = "";
            // 
            // TextEditor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox);
            Controls.Add(labelTitle);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "TextEditor";
            Text = "Soạn thảo văn bản";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem systemToolStripMenuItem;
        private ToolStripMenuItem formatToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButtonNew;
        private ToolStripButton toolStripButtonSave;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripComboBox toolStripComboBoxFont;
        private ToolStripComboBox toolStripComboBoxSize;
        private ToolStripButton toolStripButtonBold;
        private ToolStripButton toolStripButtonItalic;
        private ToolStripButton toolStripButtonUnderline;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Label labelTitle;
        private RichTextBox richTextBox;
    }
}

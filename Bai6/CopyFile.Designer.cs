namespace Bai6
{
    partial class CopyFile
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
            groupBox1 = new GroupBox();
            buttonCopy = new Button();
            buttonDes = new Button();
            buttonSource = new Button();
            textBoxDes = new TextBox();
            textBoxSource = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            progressBar1 = new ProgressBar();
            button2 = new Button();
            button3 = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = SystemColors.ButtonFace;
            groupBox1.Controls.Add(buttonCopy);
            groupBox1.Controls.Add(buttonDes);
            groupBox1.Controls.Add(buttonSource);
            groupBox1.Controls.Add(textBoxDes);
            groupBox1.Controls.Add(textBoxSource);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.Location = new Point(39, 39);
            groupBox1.Margin = new Padding(30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(698, 209);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sao chép tập tin";
            // 
            // buttonCopy
            // 
            buttonCopy.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonCopy.BackColor = SystemColors.ControlDark;
            buttonCopy.FlatStyle = FlatStyle.Flat;
            buttonCopy.Location = new Point(313, 139);
            buttonCopy.Margin = new Padding(10, 10, 30, 10);
            buttonCopy.Name = "buttonCopy";
            buttonCopy.Size = new Size(102, 49);
            buttonCopy.TabIndex = 6;
            buttonCopy.Text = "Sao chép";
            buttonCopy.UseVisualStyleBackColor = false;
            buttonCopy.Click += buttonCopy_Click;
            // 
            // buttonDes
            // 
            buttonDes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDes.BackColor = SystemColors.ControlDark;
            buttonDes.FlatStyle = FlatStyle.Flat;
            buttonDes.Location = new Point(605, 85);
            buttonDes.Margin = new Padding(10, 10, 30, 10);
            buttonDes.Name = "buttonDes";
            buttonDes.Size = new Size(60, 34);
            buttonDes.TabIndex = 5;
            buttonDes.Text = "...";
            buttonDes.UseVisualStyleBackColor = false;
            buttonDes.Click += buttonDes_Click;
            // 
            // buttonSource
            // 
            buttonSource.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSource.BackColor = SystemColors.ControlDark;
            buttonSource.FlatStyle = FlatStyle.Flat;
            buttonSource.Location = new Point(605, 37);
            buttonSource.Margin = new Padding(10, 10, 30, 10);
            buttonSource.Name = "buttonSource";
            buttonSource.Size = new Size(60, 34);
            buttonSource.TabIndex = 4;
            buttonSource.Text = "...";
            buttonSource.UseVisualStyleBackColor = false;
            buttonSource.Click += buttonSource_Click;
            // 
            // textBoxDes
            // 
            textBoxDes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxDes.BorderStyle = BorderStyle.FixedSingle;
            textBoxDes.Location = new Point(313, 85);
            textBoxDes.Margin = new Padding(10);
            textBoxDes.Name = "textBoxDes";
            textBoxDes.Size = new Size(272, 34);
            textBoxDes.TabIndex = 3;
            // 
            // textBoxSource
            // 
            textBoxSource.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSource.BorderStyle = BorderStyle.FixedSingle;
            textBoxSource.Location = new Point(313, 37);
            textBoxSource.Margin = new Padding(10);
            textBoxSource.Name = "textBoxSource";
            textBoxSource.Size = new Size(272, 34);
            textBoxSource.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 88);
            label2.Margin = new Padding(30, 10, 10, 10);
            label2.Name = "label2";
            label2.Size = new Size(237, 28);
            label2.TabIndex = 1;
            label2.Text = "Đường Dẫn Thư mục Đích";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 40);
            label1.Margin = new Padding(30, 10, 10, 10);
            label1.Name = "label1";
            label1.Size = new Size(260, 28);
            label1.TabIndex = 0;
            label1.Text = "Đường Dẫn Thư Mục Nguồn";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.BackColor = SystemColors.Control;
            groupBox2.Controls.Add(progressBar1);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button3);
            groupBox2.Font = new Font("Segoe UI", 12F);
            groupBox2.Location = new Point(39, 267);
            groupBox2.Margin = new Padding(30);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(698, 119);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tiến trình sao chép";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(33, 46);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(632, 46);
            progressBar1.TabIndex = 6;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = SystemColors.ControlDark;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(1103, 85);
            button2.Margin = new Padding(10, 10, 30, 10);
            button2.Name = "button2";
            button2.Size = new Size(60, 34);
            button2.TabIndex = 5;
            button2.Text = "...";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.BackColor = SystemColors.ControlDark;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(1103, 37);
            button3.Margin = new Padding(10, 10, 30, 10);
            button3.Name = "button3";
            button3.Size = new Size(60, 34);
            button3.TabIndex = 4;
            button3.Text = "...";
            button3.UseVisualStyleBackColor = false;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusStrip1.Location = new Point(0, 487);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(776, 26);
            statusStrip1.TabIndex = 8;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(151, 20);
            toolStripStatusLabel.Text = "toolStripStatusLabel1";
            // 
            // CopyFile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(776, 513);
            Controls.Add(statusStrip1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "CopyFile";
            Text = "Sao chép tập tin";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox textBoxSource;
        private Button buttonDes;
        private Button buttonSource;
        private TextBox textBoxDes;
        private Button buttonCopy;
        private GroupBox groupBox2;
        private ProgressBar progressBar1;
        private Button button2;
        private Button button3;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel;
    }
}

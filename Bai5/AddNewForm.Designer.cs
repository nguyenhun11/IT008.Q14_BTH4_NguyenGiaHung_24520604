namespace Bai5
{
    partial class AddNewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            labelTitle = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxMSSV = new TextBox();
            textBoxName = new TextBox();
            textBoxDiem = new TextBox();
            comboBoxKhoa = new ComboBox();
            buttonExit = new Button();
            buttonAdd = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(137, 94);
            label1.Margin = new Padding(10);
            label1.Name = "label1";
            label1.Size = new Size(154, 28);
            label1.TabIndex = 0;
            label1.Text = "Mã Số Sinh Viên";
            // 
            // labelTitle
            // 
            labelTitle.BackColor = Color.PaleTurquoise;
            labelTitle.Dock = DockStyle.Top;
            labelTitle.Font = new Font("Segoe UI Black", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.Location = new Point(0, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(800, 60);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "Thêm sinh viên";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(137, 142);
            label2.Margin = new Padding(10);
            label2.Name = "label2";
            label2.Size = new Size(125, 28);
            label2.TabIndex = 2;
            label2.Text = "Tên Sinh viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(137, 190);
            label3.Margin = new Padding(10);
            label3.Name = "label3";
            label3.Size = new Size(57, 28);
            label3.TabIndex = 3;
            label3.Text = "Khoa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(137, 238);
            label4.Margin = new Padding(10);
            label4.Name = "label4";
            label4.Size = new Size(84, 28);
            label4.TabIndex = 4;
            label4.Text = "Điểm TB";
            // 
            // textBoxMSSV
            // 
            textBoxMSSV.BorderStyle = BorderStyle.FixedSingle;
            textBoxMSSV.Font = new Font("Segoe UI", 12F);
            textBoxMSSV.Location = new Point(304, 91);
            textBoxMSSV.Name = "textBoxMSSV";
            textBoxMSSV.Size = new Size(326, 34);
            textBoxMSSV.TabIndex = 1;
            // 
            // textBoxName
            // 
            textBoxName.BorderStyle = BorderStyle.FixedSingle;
            textBoxName.Font = new Font("Segoe UI", 12F);
            textBoxName.Location = new Point(304, 139);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(326, 34);
            textBoxName.TabIndex = 2;
            // 
            // textBoxDiem
            // 
            textBoxDiem.BorderStyle = BorderStyle.FixedSingle;
            textBoxDiem.Font = new Font("Segoe UI", 12F);
            textBoxDiem.Location = new Point(304, 235);
            textBoxDiem.Name = "textBoxDiem";
            textBoxDiem.Size = new Size(326, 34);
            textBoxDiem.TabIndex = 4;
            // 
            // comboBoxKhoa
            // 
            comboBoxKhoa.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxKhoa.Font = new Font("Segoe UI", 12F);
            comboBoxKhoa.FormattingEnabled = true;
            comboBoxKhoa.Items.AddRange(new object[] { "Công nghệ phần mềm", "Khoa học máy tính", "Kỹ thuật máy tính", "Công nghệ thông tin", "Mạng máy tính và truyền thông", "Hệ thống thông tin" });
            comboBoxKhoa.Location = new Point(304, 187);
            comboBoxKhoa.Name = "comboBoxKhoa";
            comboBoxKhoa.Size = new Size(326, 36);
            comboBoxKhoa.TabIndex = 3;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.Salmon;
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Font = new Font("Segoe UI", 12F);
            buttonExit.Location = new Point(480, 306);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(150, 50);
            buttonExit.TabIndex = 6;
            buttonExit.Text = "Thoát";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.PaleGreen;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Segoe UI", 12F);
            buttonAdd.Location = new Point(304, 306);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(170, 50);
            buttonAdd.TabIndex = 5;
            buttonAdd.Text = "Thêm mới";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // AddNewForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonAdd);
            Controls.Add(buttonExit);
            Controls.Add(comboBoxKhoa);
            Controls.Add(textBoxDiem);
            Controls.Add(textBoxName);
            Controls.Add(textBoxMSSV);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(labelTitle);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "AddNewForm";
            Text = "Thêm Sinh Viên ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelTitle;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxMSSV;
        private TextBox textBoxName;
        private TextBox textBoxDiem;
        private ComboBox comboBoxKhoa;
        private Button buttonExit;
        private Button buttonAdd;
    }
}
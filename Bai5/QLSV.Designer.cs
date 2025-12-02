namespace Bai5
{
    partial class QLSV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLSV));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            menuStrip1 = new MenuStrip();
            chứcNăngToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripButtonAdd = new ToolStripButton();
            toolStripLabel1 = new ToolStripLabel();
            toolStripTextBoxSearch = new ToolStripTextBox();
            dataGridView = new DataGridView();
            STT = new DataGridViewTextBoxColumn();
            MSSV = new DataGridViewTextBoxColumn();
            Ten = new DataGridViewTextBoxColumn();
            Khoa = new DataGridViewTextBoxColumn();
            Diem = new DataGridViewTextBoxColumn();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.ForestGreen;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { chứcNăngToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // chứcNăngToolStripMenuItem
            // 
            chứcNăngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addToolStripMenuItem, exitToolStripMenuItem });
            chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            chứcNăngToolStripMenuItem.Size = new Size(93, 24);
            chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            addToolStripMenuItem.Size = new Size(212, 26);
            addToolStripMenuItem.Text = "Thêm mới";
            addToolStripMenuItem.Click += addToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(212, 26);
            exitToolStripMenuItem.Text = "Thoát";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.BackColor = Color.Honeydew;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButtonAdd, toolStripLabel1, toolStripTextBoxSearch });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 50);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonAdd
            // 
            toolStripButtonAdd.AutoSize = false;
            toolStripButtonAdd.BackColor = Color.LightGreen;
            toolStripButtonAdd.Font = new Font("Segoe UI", 12F);
            toolStripButtonAdd.Image = (Image)resources.GetObject("toolStripButtonAdd.Image");
            toolStripButtonAdd.ImageAlign = ContentAlignment.MiddleLeft;
            toolStripButtonAdd.ImageTransparentColor = Color.Magenta;
            toolStripButtonAdd.Name = "toolStripButtonAdd";
            toolStripButtonAdd.Size = new Size(200, 50);
            toolStripButtonAdd.Text = "Thêm mới";
            toolStripButtonAdd.Click += toolStripButtonAdd_Click;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Font = new Font("Segoe UI", 12F);
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(169, 47);
            toolStripLabel1.Text = "Tìm kiếm theo tên";
            // 
            // toolStripTextBoxSearch
            // 
            toolStripTextBoxSearch.BorderStyle = BorderStyle.FixedSingle;
            toolStripTextBoxSearch.Font = new Font("Segoe UI", 12F);
            toolStripTextBoxSearch.Name = "toolStripTextBoxSearch";
            toolStripTextBoxSearch.Size = new Size(250, 50);
            toolStripTextBoxSearch.TextChanged += toolStripTextBoxSearch_TextChanged;
            // 
            // dataGridView
            // 
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = Color.DarkSeaGreen;
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { STT, MSSV, Ten, Khoa, Diem });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(0, 78);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.DividerHeight = 1;
            dataGridView.RowTemplate.ReadOnly = true;
            dataGridView.Size = new Size(800, 372);
            dataGridView.TabIndex = 2;
            dataGridView.Sorted += dataGridView_Sorted;
            // 
            // STT
            // 
            STT.HeaderText = "Số TT";
            STT.MinimumWidth = 6;
            STT.Name = "STT";
            STT.ReadOnly = true;
            // 
            // MSSV
            // 
            MSSV.HeaderText = "Mã Số SV";
            MSSV.MinimumWidth = 6;
            MSSV.Name = "MSSV";
            // 
            // Ten
            // 
            Ten.HeaderText = "Tên Sinh Viên";
            Ten.MinimumWidth = 6;
            Ten.Name = "Ten";
            // 
            // Khoa
            // 
            Khoa.HeaderText = "Khoa";
            Khoa.MinimumWidth = 6;
            Khoa.Name = "Khoa";
            // 
            // Diem
            // 
            Diem.HeaderText = "Điểm TB";
            Diem.MinimumWidth = 6;
            Diem.Name = "Diem";
            // 
            // QLSV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "QLSV";
            Text = "Quản lý sinh viên";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem chứcNăngToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButtonAdd;
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox toolStripTextBoxSearch;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn MSSV;
        private DataGridViewTextBoxColumn Ten;
        private DataGridViewTextBoxColumn Khoa;
        private DataGridViewTextBoxColumn Diem;
    }
}

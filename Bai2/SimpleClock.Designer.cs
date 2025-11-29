namespace Bai2
{
    partial class SimpleClock
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
            components = new System.ComponentModel.Container();
            title = new Label();
            labelMain = new Label();
            clock = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // title
            // 
            title.BackColor = SystemColors.ActiveCaptionText;
            title.Dock = DockStyle.Top;
            title.Font = new Font("Segoe UI Black", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title.ForeColor = SystemColors.Control;
            title.Location = new Point(0, 0);
            title.Name = "title";
            title.Size = new Size(800, 60);
            title.TabIndex = 0;
            title.Text = "Simple Clock";
            title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelMain
            // 
            labelMain.Dock = DockStyle.Fill;
            labelMain.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMain.Location = new Point(0, 60);
            labelMain.Name = "labelMain";
            labelMain.Size = new Size(800, 390);
            labelMain.TabIndex = 1;
            labelMain.Text = "Ngày giờ";
            labelMain.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // clock
            // 
            clock.Tick += clock_Tick;
            // 
            // SimpleClock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelMain);
            Controls.Add(title);
            Name = "SimpleClock";
            Text = "SimpleClock";
            Load += this.SimpleClock_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label title;
        private Label labelMain;
        private System.Windows.Forms.Timer clock;
    }
}

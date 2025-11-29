using System.Drawing;

namespace Bai1
{
    partial class MouseKey
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
            this.title = new System.Windows.Forms.Label();
            this.labelNotice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.LightSkyBlue;
            this.title.Dock = System.Windows.Forms.DockStyle.Top;
            this.title.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.AliceBlue;
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(643, 60);
            this.title.TabIndex = 0;
            this.title.Text = "Mouse and Key";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNotice
            // 
            this.labelNotice.BackColor = System.Drawing.Color.LightSteelBlue;
            this.labelNotice.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelNotice.Location = new System.Drawing.Point(0, 404);
            this.labelNotice.Name = "labelNotice";
            this.labelNotice.Size = new System.Drawing.Size(643, 48);
            this.labelNotice.TabIndex = 2;
            this.labelNotice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MouseKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(643, 452);
            this.Controls.Add(this.labelNotice);
            this.Controls.Add(this.title);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MouseKey";
            this.Text = "Mouse and Key";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MouseKey_KeyPress);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MouseKey_MouseClick);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label title;

        #endregion

        private System.Windows.Forms.Label labelNotice;
    }
}
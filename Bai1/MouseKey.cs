using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class MouseKey : Form
    {
        public MouseKey()
        {
            InitializeComponent();
        }

        private void ShowMessage(string msg)
        {
            labelNotice.Text = msg;
        }


        private void MouseKey_MouseClick(object sender, MouseEventArgs e)
        {
            ShowMessage($"Mouse Click on ({e.X.ToString()}, {e.Y.ToString()})");
        }

        private void MouseKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            ShowMessage($"Key Pressed: '{e.KeyChar.ToString()}' with ASCII code {(int)e.KeyChar}");
        }
    }
}
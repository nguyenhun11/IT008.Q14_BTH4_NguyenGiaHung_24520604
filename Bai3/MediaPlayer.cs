namespace Bai3
{
    public partial class MediaPlayer : Form
    {
        public MediaPlayer()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Video/Sound File | *.avi; *.mpeg; *.wav; *.midi; *.mp4; *.mp3";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.Text = Path.GetFileName(dialog.FileName);
                axWindowsMediaPlayer1.URL = dialog.FileName;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Hôm nay là ngày " + DateTime.Now.ToString("dd/MM/yyyy") + " - Bây giờ là " + DateTime.Now.ToString("HH:mm:ss tt").ToUpper();
        }
    }
}

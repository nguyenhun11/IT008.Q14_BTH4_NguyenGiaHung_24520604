using Microsoft.VisualBasic.Devices;

namespace Bai2
{
    public partial class SimpleClock : Form
    {
        public SimpleClock()
        {
            InitializeComponent();
        }

        private void clock_Tick(object sender, EventArgs e)
        {
            labelMain.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy HH:mm:ss tt");
        }

        private void SimpleClock_Load(object sender, EventArgs e)
        {
            clock.Start();
        }
    }
}

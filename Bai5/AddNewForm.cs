namespace Bai5
{
    public partial class AddNewForm : Form
    {
        public AddNewForm()
        {
            InitializeComponent();
        }
        public Student newStudent;

        private bool ValidInfo()
        {
            bool isValid = true;

            if (textBoxMSSV.Text == "" || textBoxName.Text == "" || textBoxDiem.Text == "")
                isValid = false;

            foreach (char c in textBoxMSSV.Text)
            {
                if ((int)c < (int)'0' || (int)c > (int)'9')
                {
                    isValid = false;
                    textBoxMSSV.Text = "";
                }
            }

            foreach (char c in textBoxName.Text)
            {
                if ((int)c >= (int)'0' && (int)c <= (int)'9')
                {
                    isValid = false;
                    textBoxName.Text = "";
                }
            }

            double temp;
            if (!double.TryParse(textBoxDiem.Text, out temp))
            {
                textBoxDiem.Text = "";
                isValid = false;
            }
            else if (temp > 10 || temp < 0)
            {
                textBoxDiem.Text = "";
                isValid = false;
            }

            return isValid;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (ValidInfo())
            {
                newStudent = new Student(textBoxMSSV.Text, textBoxName.Text, comboBoxKhoa.Text, double.Parse(textBoxDiem.Text));
                this.Close();
            }
            else MessageBox.Show("Vui lòng điền lại các thông tin bị sai hoặc chưa được điền");

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (textBoxMSSV.Text == "" && textBoxName.Text == "" && textBoxDiem.Text == "")
                this.Close();
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "XÁC NHẬN", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }
    }
}

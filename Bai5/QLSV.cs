namespace Bai5
{
    public partial class QLSV : Form
    {
        public QLSV()
        {
            InitializeComponent();
        }

        private void UpdateTT()
        {
            int stt = 1;
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                if (dataGridView.Rows[i].Visible && !dataGridView.Rows[i].IsNewRow)
                {
                    dataGridView.Rows[i].Cells[0].Value = stt.ToString();
                    stt++;
                }
            }
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            addToolStripMenuItem_Click(sender, e);
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewForm addStudent = new AddNewForm();
            addStudent.ShowDialog();

            if (addStudent.newStudent != null)
            {
                dataGridView.Rows.Add(
                    "",
                    addStudent.newStudent.ID,
                    addStudent.newStudent.name,
                    addStudent.newStudent.apartment,
                    addStudent.newStudent.score.ToString()
                );
                UpdateTT();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripTextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = toolStripTextBoxSearch.Text.ToLower().Trim();
            dataGridView.SuspendLayout();

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    var cellValue = row.Cells[2].Value;

                    if (cellValue != null && cellValue.ToString().ToLower().Contains(keyword))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        try
                        {
                            row.Visible = false;
                        }
                        catch (Exception)
                        {
                            dataGridView.CurrentCell = null;
                            row.Visible = false;
                        }
                    }
                }
            }

            dataGridView.ResumeLayout();

            UpdateTT();
        }

        private void dataGridView_Sorted(object sender, EventArgs e)
        {
            UpdateTT();
        }
    }
}
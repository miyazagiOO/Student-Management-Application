using System.Text;

namespace Student_Management_Application
{
    public partial class Form1 : Form
    {
        GPA uu = new GPA();
        public Form1()
        {
            InitializeComponent();
        }

        private void addDataToGridView(string id, string name, string major)
        {
            this.dataGridView1.Rows.Add(new string[] { "id", "name", "major" });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = textBox1.Text;
            dataGridView1.Rows[n].Cells[1].Value = textBox2.Text;
            dataGridView1.Rows[n].Cells[2].Value = comboBox1.Text;
            dataGridView1.Rows[n].Cells[3].Value = textBox7.Text;

            string input = this.textBox7.Text;
            string name = this.textBox2.Text;
            double dInpu = Convert.ToDouble(input);
            uu.addGPA(dInpu, name);

            double gpax = uu.gatGPAx();
            textBox4.Text = gpax.ToString();

            double max = uu.getMax();
            textBox5.Text = max.ToString();

            double min = uu.gatMin();
            textBox6.Text = min.ToString();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "CSV(*.csv)|*.csv";
                bool fileError = false;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = dataGridView1.Columns.Count;
                            string column = "";
                            string[] outputCSV = new string[dataGridView1.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                column += dataGridView1.Columns[i].HeaderText.ToString() + ",";
                            }
                            outputCSV[0] += column;
                            for (int i = 1; (i - 1) < dataGridView1.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCSV[i] += dataGridView1.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                }
                            }
                            File.WriteAllLines(saveFileDialog.FileName, outputCSV, Encoding.UTF8);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
        }
    }
}
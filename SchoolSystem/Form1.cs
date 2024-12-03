using System.IO;
namespace SchoolSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowData()
        {
            dataGridView1.Rows.Clear();
            try
            {
                using (StreamReader reader = new StreamReader("DB/Students.txt"))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] splitLine = line.Split(',');
                        if (splitLine.Length == 3)
                        {
                            string studentName = splitLine[0];
                            string className = splitLine[1];
                            string grade = splitLine[2];
            
                            dataGridView1.Rows.Add(studentName, className, grade);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while reading data: " + ex.Message);
            }
        }
        
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string studentName = row.Cells[0].Value.ToString();
                string className = row.Cells[1].Value.ToString();
                string grade = row.Cells[2].Value.ToString();
                
                UpdateFile(studentName, className, grade, e.RowIndex);
            }
        }

        private void UpdateFile(string studentName, string className, string grade, int rowIndex)
        {
            string[] lines = File.ReadAllLines("DB/Students.txt");
            lines[rowIndex] = $"{studentName}|{className}|{grade}";
            File.WriteAllLines("DB/Students.txt", lines);
        }
        
        private void Form1_Load_1(object sender, EventArgs e)
        {
            ShowData();
            this.dataGridView1.CellValueChanged += new DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}

using System.IO;
namespace SchoolSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InsertData()
        {
            try
            {
                if (int.TryParse(maskedTextBox4.Text, out int id) && !string.IsNullOrEmpty(maskedTextBox1.Text) &&
                    !string.IsNullOrEmpty(maskedTextBox2.Text) && !string.IsNullOrEmpty(maskedTextBox3.Text))
                {
                    using (StreamWriter writer = new StreamWriter("DB/Students.txt", true))
                    {
                        string extraLine = maskedTextBox4.Text + "|" + maskedTextBox1.Text + "|" + maskedTextBox2.Text + "|" +
                                           maskedTextBox3.Text;
                        writer.WriteLine(extraLine);
                    }
                    maskedTextBox1.Clear();
                    maskedTextBox2.Clear();
                    maskedTextBox3.Clear();
                    maskedTextBox4.Clear();
                }
                else
                {
                    MessageBox.Show("Please enter valid data.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while writing data: " + ex.Message);
            }
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
                        string[] splitLine = line.Split('|');
                        if (splitLine.Length == 4)
                        {
                            string ID = splitLine[0];
                            string studentName = splitLine[1];
                            string className = splitLine[2];
                            string grade = splitLine[3];
            
                            dataGridView1.Rows.Add(ID, studentName, className, grade);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while reading data: " + ex.Message);
            }
        }

        private void NewID()
        {
            string TextFile = Application.StartupPath + @"\DB\Students.txt";
            if (System.IO.File.Exists(TextFile))
            {
                string[] lines = System.IO.File.ReadAllLines(TextFile);
                if (lines.Length > 0)
                {
                    string lastLine = lines[lines.Length - 1].Trim();
                    if (!string.IsNullOrEmpty(lastLine))
                    {
                        string[] splitedLine = lastLine.Split('|');
                        if (splitedLine.Length > 0 && int.TryParse(splitedLine[0], out int lastID))
                        {
                            maskedTextBox4.Text = (lastID + 1).ToString();
                        }
                        else
                        {
                            MessageBox.Show("The ID in the file is not in a correct format.");
                            maskedTextBox4.Text = "1";
                        }
                    }
                    else
                    {
                        maskedTextBox4.Text = "1";
                    }
                }
                else
                {
                    maskedTextBox4.Text = "1";
                }
            }
            else
            {
                maskedTextBox4.Text = "1";
            }
        }


        private void Form1_Load_1(object sender, EventArgs e)
        {
            ShowData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertData();
            ShowData();
            NewID();
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

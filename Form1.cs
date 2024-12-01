using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectteamun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnAddAssignment_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                MessageBox.Show($"File selected: {filePath}");
            }
        }
        private void btnDeleteAssignment_Click(object sender, EventArgs e)
        {
            MessageBox.Show("All assignments deleted!");
        }
        private void btnAddGrades_Click(object sender, EventArgs e)
        {
            Form gradesForm = new Form();
            gradesForm.Text = "Add Grades";
            gradesForm.ShowDialog();
        }
    }
}

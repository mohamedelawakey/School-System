using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TeacherAbsenceManager
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsAbsent { get; set; }
        public string Notes { get; set; }
    }

    public class MainForm : Form
    {
        private DataGridView dataGridView;
        private Button saveButton;
        private Button exitButton;

        private List<Teacher> teachers;

        public MainForm()
        {
            InitializeComponents();
            LoadTeachers();
        }

        private void InitializeComponents()
        {
            // Initialize main form properties
            this.Text = "Teacher Absence Manager";
            this.Width = 800;
            this.Height = 600;

            // DataGridView
            dataGridView = new DataGridView
            {
                Dock = DockStyle.Top,
                Height = 400,
                AutoGenerateColumns = true
            };

            // Save Button
            saveButton = new Button
            {
                Text = "Save",
                Dock = DockStyle.Left,
                Width = 100
            };
            saveButton.Click += SaveButton_Click;

            // Exit Button
            exitButton = new Button
            {
                Text = "Exit",
                Dock = DockStyle.Right,
                Width = 100
            };
            exitButton.Click += ExitButton_Click;

            // Add controls to the form
            this.Controls.Add(dataGridView);
            this.Controls.Add(saveButton);
            this.Controls.Add(exitButton);
        }

        private void LoadTeachers()
        {
            // Initialize the teacher list
            teachers = new List<Teacher>
            {
                new Teacher { Id = 1, Name = "John Smith", IsAbsent = false, Notes = "" },
                new Teacher { Id = 2, Name = "Jane Doe", IsAbsent = false, Notes = "" },
                new Teacher { Id = 3, Name = "Michael Brown", IsAbsent = false, Notes = "" }
            };

            // Bind data to the DataGridView
            dataGridView.DataSource = teachers;

            // Customize column headers
            dataGridView.Columns["Id"].Visible = false; // Hide the ID column
            dataGridView.Columns["Name"].HeaderText = "Teacher Name";
            dataGridView.Columns["IsAbsent"].HeaderText = "Absent";
            dataGridView.Columns["Notes"].HeaderText = "Notes";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.DataBoundItem is Teacher teacher)
                {
                    teacher.IsAbsent = Convert.ToBoolean(row.Cells["IsAbsent"].Value);
                    teacher.Notes = row.Cells["Notes"].Value?.ToString();
                }
            }

            MessageBox.Show("Data saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}

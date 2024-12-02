using System;
using System.Windows.Forms;

// add 
public class AddTeacherForm : Form
{
    // Fields to capture teacher's information
    private TextBox txtName, txtAge, txtNationalID, txtAddress, txtPosition, txtPhoneNumber, txtCourses, txtStudentsCount, txtClassesCount;
    private Button btnSave, btnCancel;

    public AddTeacherForm()
    {
        // Form setup
        this.Text = "Add teacher";
        this.BackColor = System.Drawing.Color.Purple;
        this.Width = 400;
        this.Height = 500;
        this.StartPosition = FormStartPosition.CenterScreen;

        // Create labels and text fields for teacher's details
        Label lblName = new Label { Text = "Teacher's Name:", ForeColor = System.Drawing.Color.White, Dock = DockStyle.Top };
        TextBox txtName = new TextBox { Dock = DockStyle.Top };

        Label lblAge = new Label { Text = "Age:", ForeColor = System.Drawing.Color.White, Dock = DockStyle.Top };
        TextBox txtAge = new TextBox { Dock = DockStyle.Top };

        Label lblNationalID = new Label { Text = "National ID:", ForeColor = System.Drawing.Color.White, Dock = DockStyle.Top };
        TextBox txtNationalID = new TextBox { Dock = DockStyle.Top };

        Label lblAddress = new Label { Text = "Address:", ForeColor = System.Drawing.Color.White, Dock = DockStyle.Top };
        TextBox txtAddress = new TextBox { Dock = DockStyle.Top };

        Label lblPosition = new Label { Text = "Job:", ForeColor = System.Drawing.Color.White, Dock = DockStyle.Top };
        TextBox txtPosition = new TextBox { Dock = DockStyle.Top };

        Label lblPhoneNumber = new Label { Text = "Phone Number:", ForeColor = System.Drawing.Color.White, Dock = DockStyle.Top };
        TextBox txtPhoneNumber = new TextBox { Dock = DockStyle.Top };

        Label lblCourses = new Label { Text = "Courses:", ForeColor = System.Drawing.Color.White, Dock = DockStyle.Top };
        TextBox txtCourses = new TextBox { Dock = DockStyle.Top };

        Label lblStudentsCount = new Label { Text = "Number of Students:", ForeColor = System.Drawing.Color.White, Dock = DockStyle.Top };
        TextBox txtStudentsCount = new TextBox { Dock = DockStyle.Top };

        Label lblClassesCount = new Label { Text = "Number of Classes:", ForeColor = System.Drawing.Color.White, Dock = DockStyle.Top };
        TextBox txtClassesCount = new TextBox { Dock = DockStyle.Top };

       // Create buttons
        Button btnSave = new Button
        {
            Text = "Save",
            Width = 100,
            Height = 30,
            BackColor = System.Drawing.Color.White,
            Dock = DockStyle.Left
        };

        Button btnCancel = new Button
        {
            Text = "Cancel",
            Width = 100,
            Height = 30,
            BackColor = System.Drawing.Color.White,
            Dock = DockStyle.Right
        };

        // Event handlers for the buttons
        btnSave.Click += (sender, e) =>
        {
            MessageBox.Show("Teacher data saved successfully!");
            this.Close();
        };

        btnCancel.Click += (sender, e) =>
        {
            this.Close();
        };

        // Add fields to the form
        this.Controls.Add(lblClassesCount);
        this.Controls.Add(txtClassesCount);
        this.Controls.Add(lblStudentsCount);
        this.Controls.Add(txtStudentsCount);
        this.Controls.Add(lblCourses);
        this.Controls.Add(txtCourses);
        this.Controls.Add(lblPhoneNumber);
        this.Controls.Add(txtPhoneNumber);
        this.Controls.Add(lblPosition);
        this.Controls.Add(txtPosition);
        this.Controls.Add(lblAddress);
        this.Controls.Add(txtAddress);
        this.Controls.Add(lblNationalID);
        this.Controls.Add(txtNationalID);
        this.Controls.Add(lblAge);
        this.Controls.Add(txtAge);
        this.Controls.Add(lblName);
        this.Controls.Add(txtName);

        // Add buttons to the form
        Panel buttonPanel = new Panel { Dock = DockStyle.Bottom, Height = 30 };
        buttonPanel.Controls.Add(btnSave);
        buttonPanel.Controls.Add(btnCancel);
        this.Controls.Add(buttonPanel);
    }

    private void BtnSave_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Teacher data has been saved.");
        this.Close();
    }

    private void BtnCancel_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}

// delete 
public class DeleteTeacherForm : Form
{
     // TextBox fields for National ID and Teacher's Name
    private TextBox txtNationalID,lblNationalID,txtName;
    // Buttons for Delete and Cancel actions
    private Button btnDelete, btnCancel;

    public DeleteTeacherForm()
    {
        // Set form properties
        this.Text = "Delete teacher";
        this.BackColor = System.Drawing.Color.Purple;
        this.Width = 400;
        this.Height = 200;
        this.StartPosition = FormStartPosition.CenterScreen;

        // Create and set properties for the Teacher's Name label
        Label lblName = new Label();
        lblName.Text = "Teacher's Name:";
        lblName.Location = new Point(20, 20);
        lblName.Size = new Size(100, 20);

        // Create and set properties for the Teacher's Name TextBox
        txtName = new TextBox();
        txtName.Location = new Point(130, 20);
        txtName.Size = new Size(200, 20);

        // Create and set properties for the National ID TextBox
        Label lblNationalID = new Label();
        lblNationalID.Text = "National ID:";
        lblNationalID.Location = new Point(20, 60);
        lblNationalID.Size = new Size(100, 20);

        // Create and set properties for the Delete button
        txtNationalID = new TextBox();
        txtNationalID.Location = new Point(130, 60);
        txtNationalID.Size = new Size(200, 20);

        // Create and set properties for the Cancel button
        Button btnDelete = new Button();
        btnDelete.Text = "Delete";
        btnDelete.Size = new Size(100, 30);
        btnDelete.Location = new Point(50, 120); 
        btnDelete.FlatAppearance.BorderSize = 0; 
        btnDelete.BackColor = Color.White;
        btnDelete.Click += BtnDelete_Click;

        Button btnCancel = new Button();
        btnCancel.Text = "Cancel";
        btnCancel.Size = new Size(100, 30);
        btnCancel.Location = new Point(this.ClientSize.Width - 150, 120); // الزرار ناحية اليمين
        btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right; 
        btnCancel.BackColor = Color.White;
        btnCancel.FlatAppearance.BorderSize = 0; 
        btnCancel.Click += BtnCancel_Click;

        // Add the controls to the form
        this.Controls.Add(lblName);
        this.Controls.Add(txtName);
        this.Controls.Add(lblNationalID);
        this.Controls.Add(txtNationalID);
        this.Controls.Add(btnDelete);
        this.Controls.Add(btnCancel);
    }

    // Event handler for the Delete button click
    private void BtnDelete_Click(object sender, EventArgs e)
    {
        string name = txtName.Text.Trim();
        string nationalID = txtNationalID.Text.Trim();

        // Check if the name or national ID is empty
        if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(nationalID))
        {
            MessageBox.Show("Please enter all required data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        // Check if the teacher exists in the database (simulation)
        bool adminExists = CheckTeacherExists(name, nationalID);

        // If the teacher exists, proceed to delete
        if (adminExists)
        {
            DeleteTeacher(name, nationalID);
            MessageBox.Show("The teacher was successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close(); 
        }
        else
        {
            MessageBox.Show("There is no teacher with this name and national number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    // Event handler for the Cancel button click
    private void BtnCancel_Click(object sender, EventArgs e)
    {
        this.Owner?.Show();
        this.Close(); 
    }

    // Method to check if the teacher exists in the database (simulation)
    private bool CheckTeacherExists(string name, string nationalID)
    {
        return name == "Teacher Name" && nationalID == "12345678901234";
    }

    // Method to delete the teacher (simulation)
    private void DeleteTeacher(string name, string nationalID)
    {
        
    }
}

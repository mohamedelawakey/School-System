using System;
using System.Windows.Forms;

public class AddStudentForm : Form
{
    // Form controls
    private TextBox txtStudentName, txtStudentAge, txtNationalID, txtStudentAddress, txtFatherName, txtCourses, txtGrade;
    private Button btnSave, btnCancel;

    public AddStudentForm()
    {
        // Set form properties
        this.Text = "Add Student";
        this.Size = new System.Drawing.Size(400, 500);

        // Create and add labels and textboxes
        AddLabel("Student Name:", 20, 20);
        txtStudentName = AddTextBox(150, 20);

        AddLabel("Student Age:", 20, 60);
        txtStudentAge = AddTextBox(150, 60);

        AddLabel("National ID:", 20, 100);
        txtNationalID = AddTextBox(150, 100);

        AddLabel("Student Address:", 20, 140);
        txtStudentAddress = AddTextBox(150, 140);

        AddLabel("Father's Name:", 20, 180);
        txtFatherName = AddTextBox(150, 180);

        AddLabel("Courses:", 20, 220);
        txtCourses = AddTextBox(150, 220);

        AddLabel("Grade:", 20, 260);
        txtGrade = AddTextBox(150, 260);

        // Add buttons
        btnSave = new Button
        {
            Text = "Save",
            Location = new System.Drawing.Point(100, 320),
            Width = 80
        };
        btnSave.Click += BtnSave_Click;
        this.Controls.Add(btnSave);

        btnCancel = new Button
        {
            Text = "Cancel",
            Location = new System.Drawing.Point(200, 320),
            Width = 80
        };
        btnCancel.Click += BtnCancel_Click;
        this.Controls.Add(btnCancel);
    }

    private void AddLabel(string text, int x, int y)
    {
        Label label = new Label
        {
            Text = text,
            Location = new System.Drawing.Point(x, y),
            AutoSize = true
        };
        this.Controls.Add(label);
    }

    private TextBox AddTextBox(int x, int y)
    {
        TextBox textBox = new TextBox
        {
            Location = new System.Drawing.Point(x, y),
            Width = 200
        };
        this.Controls.Add(textBox);
        return textBox;
    }

    private void BtnSave_Click(object sender, EventArgs e)
    {
        // Example: Gather data and show it in a MessageBox
        string studentData = $"Name: {txtStudentName.Text}\n" +
                             $"Age: {txtStudentAge.Text}\n" +
                             $"National ID: {txtNationalID.Text}\n" +
                             $"Address: {txtStudentAddress.Text}\n" +
                             $"Father's Name: {txtFatherName.Text}\n" +
                             $"Courses: {txtCourses.Text}\n" +
                             $"Grade: {txtGrade.Text}";

        MessageBox.Show("Student data saved:\n" + studentData, "Saved");
    }

    private void BtnCancel_Click(object sender, EventArgs e)
    {
        // Close the form
        this.Close();
    }
}
public class Program
{
    [STAThread]
    public static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        // Run the main form or AddStudentForm directly for testing
        Application.Run(new AddStudentForm());
    }
}
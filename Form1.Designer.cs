namespace mypro
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // التعريفات الخاصة بالأدوات
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblNationalID;
        private System.Windows.Forms.Label lblStudents;
        private System.Windows.Forms.Label lblClasses;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Button btnAbsence;
        private System.Windows.Forms.Button btnAssignment;

        // تنظيف الموارد المستخدمة
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // الكود الذي ينشئ الأدوات ويضبط خصائصها
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Teacher Data";

            // إنشاء الأدوات
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblNationalID = new System.Windows.Forms.Label();
            this.lblStudents = new System.Windows.Forms.Label();
            this.lblClasses = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.btnAbsence = new System.Windows.Forms.Button();
            this.btnAssignment = new System.Windows.Forms.Button();

            // تعيين خصائص الأدوات
            this.lblFullName.Text = "Full Name: John Doe";
            this.lblFullName.Location = new System.Drawing.Point(30, 30);
            
            this.lblAge.Text = "Age: 35";
            this.lblAge.Location = new System.Drawing.Point(30, 70);

            this.lblPosition.Text = "Position: Professor";
            this.lblPosition.Location = new System.Drawing.Point(30, 110);

            this.lblNationalID.Text = "National ID: 123456789";
            this.lblNationalID.Location = new System.Drawing.Point(30, 150);

            this.lblStudents.Text = "Number of Students: 50";
            this.lblStudents.Location = new System.Drawing.Point(30, 190);

            this.lblClasses.Text = "Number of Classes: 5";
            this.lblClasses.Location = new System.Drawing.Point(30, 230);

            this.lblAddress.Text = "Address: Cairo, Egypt";
            this.lblAddress.Location = new System.Drawing.Point(30, 270);

            this.lblPhone.Text = "Phone: 010-12345678";
            this.lblPhone.Location = new System.Drawing.Point(30, 310);

            // إعداد زر الغياب
            this.btnAbsence.Text = "Absence";
            this.btnAbsence.Location = new System.Drawing.Point(30, 350);
            this.btnAbsence.Click += new System.EventHandler(this.btnAbsence_Click);

            // إعداد زر الواجبات
            this.btnAssignment.Text = "Assignments";
            this.btnAssignment.Location = new System.Drawing.Point(150, 350);
            this.btnAssignment.Click += new System.EventHandler(this.btnAssignment_Click);

            // إضافة الأدوات إلى النموذج
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblNationalID);
            this.Controls.Add(this.lblStudents);
            this.Controls.Add(this.lblClasses);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.btnAbsence);
            this.Controls.Add(this.btnAssignment);
        }
    }
}

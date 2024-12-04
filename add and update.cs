partial class AddAdministratorForm
{
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.TextBox txtAge;
    private System.Windows.Forms.TextBox txtNationalId;
    private System.Windows.Forms.TextBox txtAddress;
    private System.Windows.Forms.TextBox txtJob;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Button btnCancel;

    private void InitializeComponent()
    {
        this.txtName = new System.Windows.Forms.TextBox();
        this.txtAge = new System.Windows.Forms.TextBox();
        this.txtNationalId = new System.Windows.Forms.TextBox();
        this.txtAddress = new System.Windows.Forms.TextBox();
        this.txtJob = new System.Windows.Forms.TextBox();
        this.btnSave = new System.Windows.Forms.Button();
        this.btnCancel = new System.Windows.Forms.Button();
        this.SuspendLayout();
        
               this.txtName.Location = new System.Drawing.Point(150, 30);
        this.txtName.Name = "txtName";
        this.txtName.Size = new System.Drawing.Size(200, 20);
        this.txtName.TabIndex = 0;

            this.txtAge.Location = new System.Drawing.Point(150, 70);
        this.txtAge.Name = "txtAge";
        this.txtAge.Size = new System.Drawing.Size(200, 20);
        this.txtAge.TabIndex = 1;

               this.txtNationalId.Location = new System.Drawing.Point(150, 110);
        this.txtNationalId.Name = "txtNationalId";
        this.txtNationalId.Size = new System.Drawing.Size(200, 20);
        this.txtNationalId.TabIndex = 2;

             this.txtAddress.Location = new System.Drawing.Point(150, 150);
        this.txtAddress.Name = "txtAddress";
        this.txtAddress.Size = new System.Drawing.Size(200, 20);
        this.txtAddress.TabIndex = 3;

               this.txtJob.Location = new System.Drawing.Point(150, 190);
        this.txtJob.Name = "txtJob";
        this.txtJob.Size = new System.Drawing.Size(200, 20);
        this.txtJob.TabIndex = 4;

           this.btnSave.Location = new System.Drawing.Point(150, 230);
        this.btnSave.Name = "btnSave";
        this.btnSave.Size = new System.Drawing.Size(75, 23);
        this.btnSave.TabIndex = 5;
        this.btnSave.Text = "Save";
        this.btnSave.UseVisualStyleBackColor = true;
        this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.btnCancel.Location = new System.Drawing.Point(275, 230);
        this.btnCancel.Name = "btnCancel";
        this.btnCancel.Size = new System.Drawing.Size(75, 23);
        this.btnCancel.TabIndex =

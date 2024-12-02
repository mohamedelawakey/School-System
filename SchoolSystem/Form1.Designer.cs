namespace SchoolSystem;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
        button1 = new System.Windows.Forms.Button();
        button2 = new System.Windows.Forms.Button();
        maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        dataGridView1 = new System.Windows.Forms.DataGridView();
        Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
        maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
        maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // button1
        // 
        button1.BackColor = System.Drawing.Color.ForestGreen;
        button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)0)), ((int)((byte)55)), ((int)((byte)128)));
        button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        button1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)220)), ((int)((byte)198)), ((int)((byte)224)));
        button1.Image = ((System.Drawing.Image)resources.GetObject("button1.Image"));
        button1.Location = new System.Drawing.Point(479, 117);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(105, 45);
        button1.TabIndex = 0;
        button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        button1.UseVisualStyleBackColor = false;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.BackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)0)), ((int)((byte)0)));
        button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)0)), ((int)((byte)55)), ((int)((byte)128)));
        button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        button2.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)220)), ((int)((byte)198)), ((int)((byte)224)));
        button2.Image = ((System.Drawing.Image)resources.GetObject("button2.Image"));
        button2.Location = new System.Drawing.Point(330, 121);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(108, 41);
        button2.TabIndex = 2;
        button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        button2.UseVisualStyleBackColor = false;
        button2.Click += button2_Click;
        // 
        // maskedTextBox3
        // 
        maskedTextBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        maskedTextBox3.Location = new System.Drawing.Point(177, 133);
        maskedTextBox3.Name = "maskedTextBox3";
        maskedTextBox3.Size = new System.Drawing.Size(114, 29);
        maskedTextBox3.TabIndex = 4;
        maskedTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        label1.Location = new System.Drawing.Point(18, 131);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(136, 31);
        label1.TabIndex = 5;
        label1.Text = "Grade";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        label2.Location = new System.Drawing.Point(18, 83);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(136, 31);
        label2.TabIndex = 6;
        label2.Text = "Class Number";
        label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        label3.Location = new System.Drawing.Point(18, 33);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(136, 31);
        label3.TabIndex = 7;
        label3.Text = "Student Name";
        label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // dataGridView1
        // 
        dataGridView1.AllowUserToAddRows = false;
        dataGridView1.AllowUserToDeleteRows = false;
        dataGridView1.BackgroundColor = System.Drawing.Color.White;
        dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
        dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
        dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
        dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
        dataGridView1.Location = new System.Drawing.Point(0, 183);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.ReadOnly = true;
        dataGridView1.RowHeadersVisible = false;
        dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        dataGridView1.RowTemplate.Height = 35;
        dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
        dataGridView1.Size = new System.Drawing.Size(653, 423);
        dataGridView1.TabIndex = 10;
        dataGridView1.Text = "dataGridView1";
        dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        // 
        // Column1
        // 
        Column1.HeaderText = "ID";
        Column1.Name = "Column1";
        Column1.ReadOnly = true;
        Column1.Visible = false;
        Column1.Width = 200;
        // 
        // Column2
        // 
        Column2.HeaderText = "Student Name";
        Column2.Name = "Column2";
        Column2.ReadOnly = true;
        Column2.Width = 400;
        // 
        // Column3
        // 
        Column3.HeaderText = "Class Number";
        Column3.Name = "Column3";
        Column3.ReadOnly = true;
        Column3.Width = 150;
        // 
        // Column4
        // 
        Column4.HeaderText = "Grade";
        Column4.Name = "Column4";
        Column4.ReadOnly = true;
        // 
        // maskedTextBox1
        // 
        maskedTextBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        maskedTextBox1.Location = new System.Drawing.Point(177, 35);
        maskedTextBox1.Name = "maskedTextBox1";
        maskedTextBox1.Size = new System.Drawing.Size(376, 29);
        maskedTextBox1.TabIndex = 11;
        maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // maskedTextBox2
        // 
        maskedTextBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        maskedTextBox2.Location = new System.Drawing.Point(177, 85);
        maskedTextBox2.Name = "maskedTextBox2";
        maskedTextBox2.Size = new System.Drawing.Size(114, 29);
        maskedTextBox2.TabIndex = 12;
        maskedTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // maskedTextBox4
        // 
        maskedTextBox4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        maskedTextBox4.Location = new System.Drawing.Point(330, 83);
        maskedTextBox4.Name = "maskedTextBox4";
        maskedTextBox4.Size = new System.Drawing.Size(114, 29);
        maskedTextBox4.TabIndex = 13;
        maskedTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)0)), ((int)((byte)87)), ((int)((byte)160)));
        ClientSize = new System.Drawing.Size(653, 606);
        Controls.Add(maskedTextBox4);
        Controls.Add(maskedTextBox2);
        Controls.Add(maskedTextBox1);
        Controls.Add(dataGridView1);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(maskedTextBox3);
        Controls.Add(button2);
        Controls.Add(button1);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Form1";
        Load += Form1_Load_1;
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.MaskedTextBox maskedTextBox4;

    private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    private System.Windows.Forms.MaskedTextBox maskedTextBox2;

    private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column4;


    private System.Windows.Forms.DataGridView dataGridView1;


    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.MaskedTextBox maskedTextBox5;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.MaskedTextBox maskedTextBox3;

    private System.Windows.Forms.Button button2;

    private System.Windows.Forms.Button button1;

    #endregion
}
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
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
        button1 = new System.Windows.Forms.Button();
        button2 = new System.Windows.Forms.Button();
        dataGridView1 = new System.Windows.Forms.DataGridView();
        Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // button1
        // 
        button1.BackColor = System.Drawing.Color.White;
        button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)0)), ((int)((byte)55)), ((int)((byte)128)));
        button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        button1.ForeColor = System.Drawing.Color.Black;
        button1.Location = new System.Drawing.Point(422, 540);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(105, 45);
        button1.TabIndex = 0;
        button1.Text = "Save";
        button1.UseVisualStyleBackColor = false;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.BackColor = System.Drawing.Color.White;
        button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)0)), ((int)((byte)55)), ((int)((byte)128)));
        button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        button2.ForeColor = System.Drawing.Color.Black;
        button2.Location = new System.Drawing.Point(140, 544);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(108, 41);
        button2.TabIndex = 2;
        button2.Text = "Cancel";
        button2.UseVisualStyleBackColor = false;
        button2.Click += button2_Click;
        // 
        // dataGridView1
        // 
        dataGridView1.AllowUserToOrderColumns = true;
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
        dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Column1, Column2, Column3 });
        dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
        dataGridView1.Location = new System.Drawing.Point(0, 0);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowHeadersVisible = false;
        dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        dataGridView1.RowTemplate.Height = 35;
        dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
        dataGridView1.Size = new System.Drawing.Size(653, 519);
        dataGridView1.TabIndex = 10;
        dataGridView1.Text = "dataGridView1";
        dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        // 
        // Column1
        // 
        Column1.HeaderText = "Student Name";
        Column1.Name = "Column1";
        Column1.Width = 400;
        // 
        // Column2
        // 
        Column2.HeaderText = "Class Number";
        Column2.Name = "Column2";
        Column2.Width = 150;
        // 
        // Column3
        // 
        Column3.HeaderText = "Grade";
        Column3.Name = "Column3";
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.DarkViolet;
        ClientSize = new System.Drawing.Size(653, 606);
        Controls.Add(dataGridView1);
        Controls.Add(button2);
        Controls.Add(button1);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Form1";
        Load += Form1_Load_1;
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column3;


    private System.Windows.Forms.DataGridView dataGridView1;


    private System.Windows.Forms.Button button2;

    private System.Windows.Forms.Button button1;

    #endregion
}
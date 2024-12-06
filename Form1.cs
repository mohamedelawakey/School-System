using System;
using System.Windows.Forms;

namespace mypro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // يمكن إضافة الأكواد الخاصة بالأحداث (Events) هنا مثل:
        // - عند الضغط على زر الغياب (Absence)
        // - عند الضغط على زر الواجبات (Assignments)
        private void btnAbsence_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Absence Page");
        }

        private void btnAssignment_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Assignments Page");
        }
    }
}

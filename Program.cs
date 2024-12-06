using System;
using System.Windows.Forms;

namespace mypro
{
    static class Program
    {
        // نقطة البداية للتطبيق
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); // تشغيل الـ Form1
        }
    }
}

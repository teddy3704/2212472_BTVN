using System;
using System.Windows.Forms;

namespace GuessNumberGame
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); // Tạo đối tượng Form1
        }
    }
}
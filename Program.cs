using System;
using System.Windows.Forms;
using GeographyQuizGame.Forms;

namespace GeographyQuizGame
{
    namespace GeographyQuizGame
    {
        public static class Program
        {
            [STAThread]
            public static void Main()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new HomePage());
            }
        }
    }
}
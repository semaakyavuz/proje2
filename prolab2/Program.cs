using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prolab2
{
    internal static class Program
    {
        public static CompanyPanel CurrentCompanyPanel;
        public static AdminPanel AdminPanel;
        public static Login LoginPanel;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

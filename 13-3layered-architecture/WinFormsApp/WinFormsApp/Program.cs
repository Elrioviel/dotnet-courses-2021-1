using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Department.DAL;
using Department.BLL;

namespace WinFormsApp
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            UserDAO usersdao = new UserDAO();
            UsersBL users = new UsersBL(usersdao);

            AwardDAO awardsdao = new AwardDAO();
            AwardsBL awards = new AwardsBL(awardsdao);
            
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(users, awards));
        }
    }
}

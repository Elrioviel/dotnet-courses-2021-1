using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Department.DAL;
using Department.BLL;
using Entities;

namespace Task1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            UserDAOdb usersdaoDB = new UserDAOdb(ConnectionString.CnnVal);
            UsersBL users = new UsersBL(usersdaoDB);

            AwardDAOdb awardsdaoDB = new AwardDAOdb(ConnectionString.CnnVal);
            AwardsBL awards = new AwardsBL(awardsdaoDB);

            UserAwardDAOdb userAwardsDB = new UserAwardDAOdb(ConnectionString.CnnVal);
            AwardsUserBL userAwards = new AwardsUserBL(userAwardsDB);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(users, awards, userAwards));
        }
    }
}

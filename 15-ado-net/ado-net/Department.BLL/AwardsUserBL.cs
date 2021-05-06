using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Department.DAL;
using Entities;

namespace Department.BLL
{
    public class AwardsUserBL : IAwardsUserBL
    {
        private readonly IUserAwardDAO userAwardsDAO;
        public AwardsUserBL(IUserAwardDAO userAwardDAO)
        {
            userAwardsDAO = userAwardDAO;
        }

        public void Add(UserAwards userAwards)
        {
            if (userAwards == null)
            {
                throw new ArgumentException("award");
            }
            userAwardsDAO.Add(userAwards);
        }

        public IEnumerable<UserAwards> GetList()
        {
            return userAwardsDAO.GetList();
        }

        public void Remove(int Award_ID, int User_ID)
        {
            userAwardsDAO.Remove(Award_ID, User_ID);
        }
        public void Add(int Users_ID, int Awards_ID)
        {
            UserAwards userAwards = new UserAwards
            {
                Award_ID = Awards_ID,
                User_ID = Users_ID
            
            };
            this.Add(userAwards);

        }
    }
}

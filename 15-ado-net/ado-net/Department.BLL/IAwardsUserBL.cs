using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Department.BLL
{
    interface IAwardsUserBL
    {
        IEnumerable<UserAwards> GetList();
        void Add(UserAwards userAwards);
        void Remove(int Award_ID, int User_ID);
    }
}

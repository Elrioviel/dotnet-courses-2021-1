using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department.DAL
{
    public interface IUserAwardDAO
    {
        void Add(Entities.UserAwards userAwards);
        void Remove(int Award_ID, int User_ID);
        List<Entities.UserAwards> GetList();
    }
}

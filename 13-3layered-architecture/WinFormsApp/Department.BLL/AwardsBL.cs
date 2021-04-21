using System;
using System.Collections.Generic;
using System.Linq;
using Entities;
using Department.DAL;

namespace Department.BLL
{
    public class AwardsBL
    {
        private readonly IAwardDAO awardsDAO;
        public static int idAward = 0;
        public AwardsBL()
        {
            awardsDAO = new AwardDAO();
        }
        public IEnumerable<Awards> GetList()
        {
            return awardsDAO.GetList();
        }
        public void Add(Awards award)
        {
            if (award == null)
            {
                throw new ArgumentException("award");
            }
            awardsDAO.Add(award);
        }
        public IEnumerable<Awards> InitList()
        {
            Add(new Awards()
            {
                AwardID = idAward,
                Title = "User of the month",
                Description = "",
                
            });
            idAward++;
            return GetList();
        }
        public IEnumerable<Awards> SortAwardByTitleAsc()
        {
            return (from a in GetList()
                    orderby a.Title ascending
                    select a);
        }
        public IEnumerable<Awards> SortAwardsByTitleDesc()
        {
            return (from a in GetList()
                    orderby a.Title descending
                    select a);
        }
        public void Add(string title, string description)
        {
            Awards award = new Awards
            {
                AwardID = idAward,
                Title = title,
                Description = description,
            };
            idAward++;
            this.Add(award);
        }
    }
}

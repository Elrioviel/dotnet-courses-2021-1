using System;
using System.Collections.Generic;
using System.Linq;
using Entities;
using Department.DAL;
using System.Collections;

namespace Department.BLL
{
    public class AwardsBL : IAwardsBL
    {
        private readonly IAwardDAO awardsDAO;
        public static int idAward = 0;
        public AwardsBL(IAwardDAO awardDAO)
        {
            awardsDAO = awardDAO;
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
            return awardsDAO.SortAwardsByTitleAsc();
        }
        public IEnumerable<Awards> SortAwardsByTitleDesc()
        {
            return awardsDAO.SortAwardsByTitleDesc();
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
        public IEnumerator<Awards> GetEnumerator()
        {
            List<Awards> myList = awardsDAO.GetList().ToList();
            for (int i = 0; i < myList.Count; i++)
            {
                yield return myList[i];

            }
        }
        public void Remove(Awards award)
        {
            awardsDAO.Remove(award);
        }


    }
}

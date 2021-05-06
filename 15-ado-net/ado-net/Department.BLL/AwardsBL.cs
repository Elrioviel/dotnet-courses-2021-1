﻿using System;
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
                Title = "User of the month",
                Description = "",

            });
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
                Title = title,
                Description = description,
            };
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
        public void Remove(int ID)
        {
            awardsDAO.Remove(ID);
        }


    }
}

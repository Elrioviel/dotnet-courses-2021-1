using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Entities;

namespace Department.DAL
{
    public class AwardDAO : IAwardDAO
    {
        private BindingList<Awards> awards = new BindingList<Awards>();

        public void Add(Awards award)
        {
            if (award == null)
                throw new ArgumentException("award");
            awards.Add(award);
        }
        public IEnumerable<Awards> GetList()
        {
            return awards;
        }
        public void Remove(Awards award)
        {
            awards.Remove(award);
        }

        public IEnumerable<Awards> SortAwardsByTitleAsc()
        {
            var sortedList = new BindingList<Awards>(awards.OrderBy(x => x.Title).ToList());
            awards = sortedList;

            return awards;
        }

        public IEnumerable<Awards> SortAwardsByTitleDesc()
        {
            var sortedListDesc = new BindingList<Awards>(awards.OrderByDescending(x => x.Title).ToList());
            awards = sortedListDesc;
            return awards;
        }
    }
    public class AwardDAOdb : IAwardDAO
    {
        public void Add(Awards award)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<Awards> GetList()
        {
            throw new NotImplementedException();
        }
        public void Remove(Awards award)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Awards> SortAwardsByTitleAsc()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Awards> SortAwardsByTitleDesc()
        {
            throw new NotImplementedException();
        }
    }
    
}

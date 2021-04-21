using System;
using System.Collections.Generic;
using Entities;

namespace Department.DAL
{
    public class AwardDAO : IAwardDAO
    {
        private List<Awards> awards = new List<Awards>();

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
    }
}

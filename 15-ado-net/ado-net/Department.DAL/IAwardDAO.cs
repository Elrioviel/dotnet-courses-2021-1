using System;
using System.Collections.Generic;

namespace Department.DAL
{
    public interface IAwardDAO
    {
        void Add(Entities.Awards award);
        void Remove(int AwardID);
        List<Entities.Awards> GetList();
        System.Collections.Generic.IEnumerable<Entities.Awards> SortAwardsByTitleAsc();
        System.Collections.Generic.IEnumerable<Entities.Awards> SortAwardsByTitleDesc();
    }
}

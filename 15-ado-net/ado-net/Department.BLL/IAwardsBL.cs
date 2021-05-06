using System;
using System.Collections.Generic;
using System.Linq;
using Entities;
using Department.DAL;
using System.Collections;

namespace Department.BLL
{
    interface IAwardsBL
    {
        IEnumerable<Awards> GetList();
        void Add(Awards award);
        IEnumerable<Awards> InitList();
        IEnumerable<Awards> SortAwardByTitleAsc();
        IEnumerable<Awards> SortAwardsByTitleDesc();
        void Remove(int ID);
    }
}


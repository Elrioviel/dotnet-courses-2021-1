using System;
using System.Collections.Generic;

namespace Department.DAL
{
    public interface IAwardDAO
    {
        void Add(Entities.Awards award);
        IEnumerable<Entities.Awards> GetList();
    }
}

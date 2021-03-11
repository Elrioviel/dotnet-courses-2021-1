using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class User
    {
        private string _birth;
        private string _last;
        private string _patronym;
        private string _first;
        public string Birth
        {
            get { return _birth; }
            set { _birth = value;  }
        }

        public string LastName
        {
            get { return _last; }
            set { _last = value; }
        }
        public string FirstName
        {
            get { return _first; }
            set { _first = value; }
        }
        public string Patronymic
        {
            get { return _patronym; }
            set { _patronym = value; }
        }
        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode();
        }

    }
}

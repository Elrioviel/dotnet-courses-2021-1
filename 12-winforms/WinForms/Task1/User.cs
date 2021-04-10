using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace Task1
{
    public class User
    {
        private int _iD;
        private string _firstName;
        private string _lastName;
        private DateTime _birthDate;
        private string _userAward;              //?//


        public int ID

        {
            get
            {
                return _iD;
            }
            set
            {
                //Guid g = Guid.NewGuid();
                //string gs = g.ToString();
                //int id = int.Parse(gs);
                this._iD = value;
            }
        }
        public string FirstName
        {
            get 
            {
                return _firstName;
            } 
            set 
            {
                this._firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                this._lastName = value;
            }
        }
        public DateTime BirthDate
        {
            get
            {
                return _birthDate;
            }
            set
            {
                if (_birthDate > DateTime.Now)
                {
                    throw new ArgumentException("Invalid date!");
                }
                else
                {
                    this._birthDate = value;
                }
            }
        }
        public int Age
        {
            get
            {
                return (DateTime.Now.Year - _birthDate.Year);
            }
        }
        public string UserAward                     //?//
        {
            get
            {
                return _userAward;
            }
            set
            {
                this._userAward = value;
            }
        }
        public User(int ID, string FirstName, string LastName, DateTime BirthDate, string UserAward)
        {
            this._iD = ID;
            this._firstName = FirstName;
            this._lastName = LastName;
            this._birthDate = BirthDate;
            this._userAward = UserAward;                //?//
            
        }
    }
    
}

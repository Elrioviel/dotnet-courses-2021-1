using System;

namespace Entities
{
    public class User
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public Awards awards { get; set; }

        
        //public int ID

        //{
        //    get
        //    {
        //        return _ID;
        //    }
        //    set
        //    {
        //        this._ID = value;
        //    }
        //}
        //public string FirstName
        //{
        //    get
        //    {
        //        return _firstName;
        //    }
        //    set
        //    {
        //        this._firstName = value;
        //    }
        //}
        //public string LastName
        //{
        //    get
        //    {
        //        return _lastName;
        //    }
        //    set
        //    {
        //        this._lastName = value;
        //    }
        //}
        //public DateTime BirthDate
        //{
        //    get
        //    {
        //        return _birthDate;
        //    }
        //    set
        //    {
        //        if (_birthDate > DateTime.Now)
        //        {
        //            throw new ArgumentException("Invalid date!");
        //        }
        //        else
        //        {
        //            this._birthDate = value;
        //        }
        //    }
        //}
        public int Age
        {
            get
            {
                return (DateTime.Now.Year - BirthDate.Year);
            }
        }
        
        //public User(int ID, string FirstName, string LastName, DateTime BirthDate, Awards userAwards)
        //{
        //    this._ID = ID;
        //    this._firstName = FirstName;
        //    this._lastName = LastName;
        //    this._birthDate = BirthDate;
        //    this._awards = userAwards;

        //}
    }
    public class Awards
    {
        public int AwardID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        //public int ID
        //{
        //    get
        //    {
        //        return _awardID;
        //    }
        //    set
        //    {
        //        this._awardID = value;
        //    }
        //}
        //public string Title
        //{
        //    get
        //    {
        //        return _title;
        //    }
        //    set
        //    {
        //        this._title = value;
        //    }
        //}
        //public string Description
        //{
        //    get
        //    {
        //        return _description;
        //    }
        //    set
        //    {
        //        this._description = value;
        //    }
        //}
        //public Awards(int AwardID, string Title, string Description)
        //{
        //    this._awardID = AwardID;
        //    this._title = Title;
        //    this._description = Description;
        //}
    }
    
}

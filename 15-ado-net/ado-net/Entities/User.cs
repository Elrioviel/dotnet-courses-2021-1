using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Entities
{

    public class User
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        private string _awardTitle { get; set; }

        public List<Awards> AwardsUser
        {
            get; set;
        }

        public string AwardTitle
        {
            get
            {
                if (AwardsUser == null)
                {
                    _awardTitle = "";
                }
                else
                {
                    _awardTitle = "";
                    foreach (Awards awards in AwardsUser)
                    {

                        _awardTitle += awards.Title + ", ";
                    }

                }
                return _awardTitle;
            }
        }

        public void Remove(Awards award)
        {
            AwardsUser.Remove(award);
        }
        public void AddAward(string UpdatedTitle, string UpdatedDescription)
        {
            Awards updatedaward = new Awards
            {
                Title = UpdatedTitle,
                Description = UpdatedDescription,
            };

            AwardsUser.Add(updatedaward);
        }

        public int Age
        {
            get
            {
                return (DateTime.Now.Year - BirthDate.Year);
            }
        }

    }
 

    public class Awards
    {
        public int AwardID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

    }

    
    public class UserAwards
    {
        public int Award_ID { get; set; }
        public int User_ID { get; set; }
        public string User_FirstName { get; set; }
        public string User_LastName { get; set; }
        public string Award_Title { get; set; }

    }

}

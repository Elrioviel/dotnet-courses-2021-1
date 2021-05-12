using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace User_Awards.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        [Required]
        [DisplayName("First name")]
        public string FirstName { get; set; }
        [Required]
        [DisplayName("Surname")]
        public string LastName { get; set; }
        [Required]
        [DisplayName("Birth date")]
        public DateTime BirthDate { get; set; }
    }
}

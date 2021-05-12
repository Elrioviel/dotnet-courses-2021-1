using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace User_Awards.Models
{
    public class Award
    {
        [Key]
        public int AwardID { get; set; }
        [DisplayName("Title")]
        [Required]
        public string AwardTitle { get; set; }
        [DisplayName("Description")]
        public string AwardDescription { get; set; }
    }
}

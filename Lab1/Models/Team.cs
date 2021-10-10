using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1.Models
{
    public class Team
    {
        [Key]
        public int Key { get; set; }

        [Required, Display(Name = "Team Name")]
        public string TeamName { get; set; }

        [Required, Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Established Date")]
        public DateTime? EstablishedDate { get; set; }
    }
}

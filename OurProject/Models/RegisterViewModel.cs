using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OurProject.Models
{
    public class RegisterViewModel
    {
        [Required]
        public String Name { get; set; }

        [Required]
        public String Password { get; set; }


    }
}

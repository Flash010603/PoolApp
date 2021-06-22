using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pool.WebApp.Models
{
    public class NewUser
    {
        [Display(Name ="Name")]
        public string Name { get; set; }
        [Display(Name ="Email")]
        public string Email { get; set; }

        [Display(Name = "Username")]
        public string Username { get; set; }
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pool.WebApp.Models
{
    public class LoginModel
    {
        [Required]
        [Display(Name ="Username")]
        public string Username { get; set; }
        [Required]
        [Display(Name = "Username")]
        public string Password { get; set; }
    }
}

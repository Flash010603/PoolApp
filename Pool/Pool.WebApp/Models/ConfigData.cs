using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pool.WebApp.Models
{
    public class ConfigData
    {
        [Display(Name = "Name_Pool")]
        public string Name_Pool { get; set; }
        [Display(Name = "Location")]
        public string Location { get; set; }
        [Display(Name = "Temp_min")]
        public decimal Temp_min { get; set; }
        [Display(Name = "Temp_max")]
        public decimal Temp_max { get; set; }
        [Display(Name = "Ph_min")]
        public decimal Ph_min { get; set; }
        [Display(Name = "Ph_max")]
        public decimal Ph_max { get; set; }
        [Display(Name = "Grados")]
        public string Grados { get; set; }
    }
}

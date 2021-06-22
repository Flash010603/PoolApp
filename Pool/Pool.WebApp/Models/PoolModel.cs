using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pool.WebApp.Models
{
    public class PoolModel
    {
        public string Id { get; set; }
        public string Name_Pool { get; set; }
       
        public string Location { get; set; }
    
        public decimal Temp_min { get; set; }

    
        public decimal Temp_max { get; set; }
        public decimal Temp_current { get; set; }
      
        public decimal Ph_min { get; set; }
     
        public decimal Ph_max { get; set; }

        public decimal Ph_current { get; set; }

        public string Grados { get; set; }

        public string IdUser { get; set; }
    }
}

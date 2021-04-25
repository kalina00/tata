using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppForDiabetes.Models
{
    public class Products
    {
        [Key]
        public int IDProduct { get; set; }
        public string Product { get; set; } 
        public int IDDiabetes { get; set; }
        //public Diabetes Diabetes { get; set; }
        public double kkal { get; set; } 
        public double XE { get; set; }
    }
}

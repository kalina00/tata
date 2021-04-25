using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppForDiabetes.Models
{
    public class Categories
    {
        [Key]
        public int IDCategory { get; set; }
        public string Category { get; set; }
       
    }
}

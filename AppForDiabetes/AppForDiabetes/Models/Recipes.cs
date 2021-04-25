using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppForDiabetes.Models
{
    public class Recipes
    {
        [Key]
        public int IDRecipe { get; set; }
        public string Recipe{ get; set; }
        public string CookingMethod { get; set; }
        public int IDCategory { get; set; }
        
    }
}

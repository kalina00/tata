using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppForDiabetes.Models
{
    public class RecipeProducts
    {
       // [Key]
        
        public int IDRecipe { get; set; }
        public int IDProduct { get; set; }
    }
    
}

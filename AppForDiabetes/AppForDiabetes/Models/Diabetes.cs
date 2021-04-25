using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AppForDiabetes.Models
{
    public class Diabetes
    {
        [Key]
        public int IDDiabetes { get; set; }
        public string Type { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace AppForDiabetes.Models
{
    public class Humans
    {
        [Key]
        public int IDHuman{ get; set; }
        [Required(ErrorMessage = "Поле должно быть заполнено!")]
        public string Name { get; set; }
        [Required]
        public bool IsWoman { get; set; }
        [Required(ErrorMessage = "Поле должно быть заполнено!")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Поле должно быть заполнено!")]
        public double Weigt { get; set; }
        [Required(ErrorMessage = "Поле должно быть заполнено!")]
        public double Height { get; set; }
        [Required(ErrorMessage = "Поле должно быть заполнено!")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Поле должно быть заполнено!")]
        public string Password { get; set; }
        
        public int IDDiabetes { get; set; }

    }
}

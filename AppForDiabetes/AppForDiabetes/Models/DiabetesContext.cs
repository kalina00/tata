using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AppForDiabetes.Models 
{
    public class DiabetesContext : DbContext
    {
        public DbSet<Products> products { get; set; }
        public DbSet<Diabetes> diabetes { get; set; }
        public DbSet<Humans> humans { get; set; }
        public DbSet<Categories> categories { get; set; }
        public DbSet<Recipes> recipes { get; set; }
        //public DbSet<RecipeProducts> recipeProducts { get; set; }
      //  public DbSet<RegistrHuman> registrHuman { get; set; }
        public DiabetesContext(DbContextOptions<DiabetesContext> options)
: base(options)
        {
            
        }

    }
}

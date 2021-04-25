using AppForDiabetes.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace AppForDiabetes.Controllers
{
    public class HomeController : Controller
    {
        DiabetesContext db;
        public HomeController(DiabetesContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Product()
        {
            return View(db.products.ToList());
        }
        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public string AddProduct(Products products)
        {

            db.products.Add(products);// сохраняем в бд все изменения
            db.SaveChanges();



            return "Спасибо, данный продукт будет добавлен";
        }

        public IActionResult Recomend()
        {

            return View();
        }

        public IActionResult Recipe()
        {

            return View(db.recipes.ToList());
        }
       
      

    }

}

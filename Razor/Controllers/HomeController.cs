using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Razor.Models;

namespace Razor.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            //Why do we fill in manually and do not create a constructor and do not fill through it
            Product[] products =
            {
                new Product {Name = "Kayak", Price= 275 },
                new Product {Name="Lifejacket", Price = 275M},
                new Product {Name ="Ball", Price=55M},
                new Product{Name = "flag", Price= 34.5M}
            };
            return View(products);
        }
    }
}

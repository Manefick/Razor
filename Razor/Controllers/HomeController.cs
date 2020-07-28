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
            Product myproduct = new Product
            {
                ProductId = 1,
                Name = "Kayak",
                Description = "А boat for one person",
                Category = "Watersports",
                Price = 275M
            };
            return View(myproduct);
        }
    }
}

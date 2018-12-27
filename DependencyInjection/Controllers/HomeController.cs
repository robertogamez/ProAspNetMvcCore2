using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjection.Models;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        public IRepository Repository { get; set; } = new MemoryRepository();

        public IActionResult Index()
        {
            return View(Repository.Products);
        }
    }
}

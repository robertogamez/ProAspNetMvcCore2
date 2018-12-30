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
        private readonly IRepository repository;
        private readonly ProductTotalizer totalizer;

        public HomeController(IRepository repo, ProductTotalizer total)
        {
            repository = repo;
            totalizer = total;
        }

        public IActionResult Index()
        {
            ViewBag.HomeController = repository.ToString();
            ViewBag.Total = totalizer.Repository.ToString();
            return View(repository.Products);
        }
    }
}

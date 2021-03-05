using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using SalesWebMvc.Models.ViewModels;

namespace SalesWebMvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()//o IActionresult é o supertipo genérico para todo o resultado de acção que devolve vários tipos: viewResult, partialViewResult
        {
            ViewData["Message"] = "Salles Web MVC App from C# Course";
            ViewData["email"] = "teste@gmail.com";
            ViewData["Student"] = "Aires";
            return View();//é um methodbuilder, um método auxiliar que retorna o IactionResult aka viewresult
            
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

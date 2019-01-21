using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Core.Contracts.Template;
using Microsoft.AspNetCore.Mvc;
using Core.Web.Models;

namespace Core.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITemplateService _templateService;

        public HomeController(ITemplateService templateService)
        {
            _templateService = templateService;
        }
        public IActionResult Index()
        {
            ViewBag.DidSomething = _templateService.DoSomething();
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

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MyCourse.Controllers
{
    // [Route("[controller]")]
    public class CoursesController : Controller
    {
        // private readonly ILogger<CoursesController> _logger;

        // public CoursesController(ILogger<CoursesController> logger)
        // {
        //     _logger = logger;
        // }

        public IActionResult Index()
        {
            // return Content("Sono Index");
            return View("Detail");
        }

         public IActionResult Detail(string id)
        {
            // return Content($"Sono Detail con id {id}");
            return View();
        }

        // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        // public IActionResult Error()
        // {
        //     return View("Error!");
        // }
    }
}
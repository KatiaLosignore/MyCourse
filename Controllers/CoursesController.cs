using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyCourse.Models.ViewModels;
using MyCourse.Models.Services.Application;

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
            
            var courseService = new CourseService();  // il controller crea un oggetto del servizio applicativo che deve utilizzare
            List<CourseViewModel> courses = courseService.GetServices();  // Recupero la lista dei corsi
        
            return View(courses);   // passo l'oggetto contenente la lista dei corsi alla view
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
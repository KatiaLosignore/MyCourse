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
        // l'attributo è di tipo interfaccia
        private readonly ICourseService courseService;

        // Il Controller per poter funzionare ha bisogno di un componente che implementa l'interfaccia ICourseService
        public CoursesController(ICourseService courseService)
        {
            this.courseService = courseService;
        }


        // private readonly ILogger<CoursesController> _logger;

        // public CoursesController(ILogger<CoursesController> logger)
        // {
        //     _logger = logger;
        // }

        public IActionResult Index()
        {   
            ViewData["Title"] = "Catalogo dei Corsi";
            // var courseService = new CourseService();  // il controller crea un oggetto del servizio applicativo che deve utilizzare
            List<CourseViewModel> courses = courseService.GetCourses();  // Recupero la lista dei corsi
        
            return View(courses);   // passo l'oggetto contenente la lista dei corsi alla view
        }

        //azione che deve recuperare i dati del corso con id = id parametro
        //popolare la view Detail.cshmtl con i dati del corso recuperato
         public IActionResult Detail(int id)
        {
            // return Content($"Sono Detail con id {id}");
            
            // var courseService = new CourseService();
            CourseDetailViewModel viewModel = courseService.GetCourse(id);
            ViewData["Title"] = viewModel.Title;
            return View(viewModel);
        }

        // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        // public IActionResult Error()
        // {
        //     return View("Error!");
        // }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyCourse.Models.ViewModels;

namespace MyCourse.Models.Services.Application
{
    //questa interfaccia mi permette di accoppiare debolmente il controller dal servizio
    //in questa interfaccia dichiaro i metodi che la classe concreta che rappresenterà il servizio dovrà implementare
    //in questa maniera qualsiasi classe che implementa questa interfaccia sarà buona per far funzionare il Controller
    public interface ICourseService
    {
        List<CourseViewModel> GetCourses();

        CourseDetailViewModel GetCourse(int id);
    }
}
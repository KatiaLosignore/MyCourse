using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyCourse.Models.ViewModels;
using MyCourse.Models.ValueTypes;
using  MyCourse.Models.Enums;


namespace MyCourse.Models.Services.Application
{
    public class CourseService
    {
        // Metodo che deve tornare la lista dei corsi
        // per adesso creiamo un algoritmo che crea dei corsi ranodm
        //successivamente leggeremo i corsi da database
        public List<CourseViewModel> GetServices()
        {
            // throw new NotImplementedException();

            var courseList = new List<CourseViewModel>();  // oggetto che conterrà la lista dei corsi
            var rand = new Random();
            for (int i = 1; i <= 20; i++)
            {
                var price = Convert.ToDecimal(rand.NextDouble() * 10 + 10);
                var course = new CourseViewModel  //creo un oggetto di tipo CourseViewModel e lo popolo in maniera random
                {
                    Id = i,
                    Title = $"Corso {i}",
                    CurrentPrice = new Money(Currency.EUR, price),
                    FullPrice = new Money(Currency.EUR, rand.NextDouble() > 0.5 ? price : price - 1),
                    Author = "Nome cognome",
                    Rating = rand.Next(10, 50) / 10.0,
                    ImagePath = "/logo.svg"
                };
                courseList.Add(course);
            }
            return courseList;
        }
    }
}
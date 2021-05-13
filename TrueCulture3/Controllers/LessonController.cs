using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrueCulture3.Models;

namespace TrueCulture3.Controllers
{
    public class LessonController : Controller
    {
        private readonly TC3Context _context;
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddLanguage()
        {
            var words = new List<Translation>()
            {
                new Translation{Id=1, originalWord = "Hola", translatedWord = "Hello" },
                new Translation{Id=2, originalWord = "Perro", translatedWord = "Dog" },
                new Translation{Id=3, originalWord = "Gato", translatedWord = "Cat" },
                new Translation{Id=4, originalWord = "Hombre", translatedWord = "Man" },
                new Translation{Id=5, originalWord = "Mujer", translatedWord = "Woman" },
                new Translation{Id=6, originalWord = "Libreria", translatedWord = "Book Store" },
                new Translation{Id=7, originalWord = "Biblioteca", translatedWord = "Library" },
                new Translation{Id=8, originalWord = "Conejo", translatedWord = "Rabbit" },
                new Translation{Id=9, originalWord = "Bien", translatedWord = "Good" },
                new Translation{Id=10, originalWord = "Adios", translatedWord = "Goodbye" },
                new Translation{Id=11, originalWord = "Nino", translatedWord = "Boy" },
                new Translation{Id=12, originalWord = "Nina", translatedWord = "Girl" },
                new Translation{Id=13, originalWord = "El", translatedWord = "Him" },
                new Translation{Id=14, originalWord = "Ella", translatedWord = "Her" },
                new Translation{Id=15, originalWord = "Conejo", translatedWord = "Rabbit" },
                new Translation{Id=16, originalWord = "Dormir", translatedWord = "Sleep" },
                new Translation{Id=17, originalWord = "Comer", translatedWord = "Eat" } };


                foreach(var x in words){

                
                

                 }

            return RedirectToAction("Home", "Index");
            

            


            
           
        }
    }
}

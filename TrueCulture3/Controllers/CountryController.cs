using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrueCulture3.Models;

namespace TrueCulture3.Controllers
{
    public class CountryController : Controller
    {
        public IActionResult ListCountries()
        {
            List<Countries> worldCountries = new List<Countries>();
            worldCountries.Add(new Countries { countryName = "Guatemala", countryLocation = "Central America" });
            worldCountries.Add(new Countries { countryName = "Mexico", countryLocation = "North America" });
            worldCountries.Add(new Countries { countryName = "Peru", countryLocation = "South America" });

            return View(worldCountries);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}

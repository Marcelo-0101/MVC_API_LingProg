using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ClinVet.Models;

namespace ClinVet.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Lista de animais fictícia
            var animals = new List<Animal>
            {
                new Animal { Id = 1, Name = "Rex", Breed = "Labrador" },
                new Animal { Id = 2, Name = "Luna", Breed = "Siamês" }
            };

            // Passa os dados para a view
            return View(animals);
        }
    }
}
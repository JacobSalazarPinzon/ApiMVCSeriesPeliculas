using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using ApiMVCSeriesPeliculas.Models;
using System.Text.Json;


namespace ApiMVCSeriesPeliculas.Controllers
{
    public class ViewModelsController : Controller
    {
        public IActionResult NuevoPersonaje()
        {
            return View();
        }
        public IActionResult ModificarPersonaje()
        {
            return View();
        }

        public IActionResult Series()
        {
            return View();
        }

    }
}

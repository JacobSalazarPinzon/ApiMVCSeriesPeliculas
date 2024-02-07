using Microsoft.AspNetCore.Mvc;

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

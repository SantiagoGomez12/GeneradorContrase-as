using Microsoft.AspNetCore.Mvc;
using GeneradorContraseñas.Models;

namespace GeneradorContraseñas.Controllers
{
    public class PasswordController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/Home/Index.cshtml", new Password());
        }

        [HttpPost]
        public IActionResult Index(Password modelo)
        {
                    if (modelo.Largo < 4)
                    {
                        ViewBag.Error = "ERROR: El valor debe ser igual o mayor a 4.";
                        return View("~/Views/Home/Index.cshtml", modelo);
                    }

                    if (modelo.Largo > 50)
                    {
                        ViewBag.Error = "ERROR: El valor debe ser igual o inferior a 50.";
                        return View("~/Views/Home/Index.cshtml", modelo);
                    }

                    if (!modelo.Mayusculas && !modelo.Minusculas &&
                        !modelo.Numeros && !modelo.Simbolos)
                    {
                        ViewBag.Error = "ERROR: Selecciona al menos un tipo de caracter.";
                        return View("~/Views/Home/Index.cshtml", modelo);
                    }

                    modelo.Generar();

                    return View("~/Views/Home/Index.cshtml", modelo);
        }
    }
}

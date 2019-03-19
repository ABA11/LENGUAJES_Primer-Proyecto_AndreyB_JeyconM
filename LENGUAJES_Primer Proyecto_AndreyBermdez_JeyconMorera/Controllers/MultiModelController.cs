using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LENGUAJES_Primer_Proyecto_AndreyBermdez_JeyconMorera.Controllers
{
    public class MultiModelController : Controller
    {
        public IActionResult Registrar()
        {
            // Initialization.  
            Models.MultiModel model = new Models.MultiModel();
            model.Anime = new Models.Anime();
            model.Pelicula = new Models.Pelicula();

            return View(model);
        
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace LENGUAJES_Primer_Proyecto_AndreyBermdez_JeyconMorera.Controllers
{
    public class MVController : Controller
    {
  
        // GET: /MV/

        public IActionResult Index()
        {
            return View();
        }
 
    
       // GET: /MV/Welcome/ 
        public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }
    }
}
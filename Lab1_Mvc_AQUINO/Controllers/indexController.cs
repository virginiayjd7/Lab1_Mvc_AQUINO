using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;

namespace Lab1_Mvc_AQUINO.Controllers
{
    public class indexController : Controller
    {
        // GET: index
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult VerInformacion()
        {
            ViewBag.Nombre="yaneth;";
            ViewBag.Apellido = "aquino;";
            ViewBag.Edad = 23;
            ViewData["talla"] = 1.75;
            ViewData["sexo"] = true;
            ViewData["fechahora"] = DateTime.Now.ToString();
            return View();
        }
    }
}
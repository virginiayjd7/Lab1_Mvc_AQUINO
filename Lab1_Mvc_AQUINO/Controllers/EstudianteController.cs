using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab1_Mvc_AQUINO.Models;

namespace Lab1_Mvc_AQUINO.Controllers
{
    public class EstudianteController : Controller
    {
        // GET: Estudiante
        public ActionResult Index()
        {
            ClsEstudiante objestudiante = new ClsEstudiante();
            objestudiante.apellido = "aquno";
            objestudiante.nombre = "yaneth";
            objestudiante.talla = 1.50;
            objestudiante.sexo = true;
            objestudiante.edad = 25;
            return View(objestudiante);
        }
    }
}
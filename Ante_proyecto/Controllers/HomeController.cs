using Ante_proyecto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ante_proyecto.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Formulario()
        {
         
            return View();
        }

        [HttpPost]
        public ActionResult FormSubmit(Formulario Formulario)
        {
            if (ModelState.IsValid)
            {
                string Cedula = Formulario.Cedula.ToString();
                string Nombre = Formulario.Nombre;
                string Apellido = Formulario.Apellido;
                string Genero = Formulario.Genero;
                string Correo = Formulario.Correo;
                string Estado = Formulario.Estado_civil;
                string Edad = Formulario.Edad.ToString();
                string Telefono = Formulario.Telefono;
                bool Hobby = Formulario.Hobby;
            }

            return View("FormSubmit", Formulario);
        }
    }
}
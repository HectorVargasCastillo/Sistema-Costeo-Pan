using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationEjemploFE.Models;


namespace WebApplicationEjemploFE.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult guardarLinea(FormCollection collection)
        {

            try
            {
                linea ln = new linea();
                ln.nombre = collection.Get("nombre");
                ln.creado_el = DateTime.Now;

                Database1Entities db = new Database1Entities();
                db.lineas.Add(ln);
                db.SaveChanges();
            }
            catch (Exception e) {
                
            }
            return Redirect("/Home/about");
        }


        public ActionResult formFamilia()
        {
            var usuarios = linea.

            var listaUsuarios = new SelectList(usuarios, "ID", "Nombre");

            ViewBag.usuarios= listaUsuarios;
            return View();
        }


        public ActionResult guardarFamilia()
        {
            
            linea ln = new linea();
            ln.nombre = "Panaderia";
            ln.creado_el = DateTime.Now;

            Database1Entities db = new Database1Entities();
            db.lineas.Add(ln);

            return Redirect("/formFamilia");

        }


        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
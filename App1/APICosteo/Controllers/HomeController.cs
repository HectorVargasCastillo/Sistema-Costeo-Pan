using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace APICosteo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            Database1Entities db = new Database1Entities();

            linea l = new linea();
            l.nombre = "panaderia";
            l.creado_el = DateTime.Now;
            l.modificado_el= DateTime.Now;

            db.lineas.Add(l);

            unidad_medida un = new unidad_medida();
            un.codigo = "un";
            un.descripcion = "Unidad de medida";
            un.creado_el = DateTime.Now;
            un.modificado_el = DateTime.Now;
            db.unidad_medida.Add(un);

            unidad_medida lt = new unidad_medida();
            lt.codigo = "lt";
            lt.descripcion = "Litros";
            lt.creado_el = DateTime.Now;
            lt.modificado_el = DateTime.Now;
            db.unidad_medida.Add(lt);

            db.SaveChanges();

            return View();
        }
    }
}

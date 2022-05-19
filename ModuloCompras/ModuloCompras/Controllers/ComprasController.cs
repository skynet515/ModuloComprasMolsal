using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModuloCompras.Controllers
{
    public class ComprasController : Controller
    {
        // GET: Compras
        public ActionResult Historico()
        {
            return View();
        }


        public ActionResult Proveedores()
        {
            return View();
        }

        public ActionResult Compras()
        {
            return View();
        }

        public ActionResult Articulos()
        {
            return View();
        }

        public ActionResult PlanificadorCompras()
        {
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModuloCompras.Controllers
{
    public class InventarioController : Controller
    {
        // GET: Historico
        public ActionResult Articulos()
        {
            return View();
        }

        public ActionResult Existencias()
        {
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using web01.Models;

namespace web01.Controllers
{
    public class InicioController : Controller
    {
        private GeneralTest01Entities db = new GeneralTest01Entities();
        // GET: Inicio
        public ActionResult Index()
        {
            IEnumerable<Usuario> usuarios = db.Usuario;
            return View(usuarios);
        }
    }
}
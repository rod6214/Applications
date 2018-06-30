using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using web01.Models;

namespace web01.Controllers
{
    public class RegistroController : Controller
    {
        private GeneralTest01Entities db = new GeneralTest01Entities();
        // GET: Registro
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registrar(Usuario usr)
        {
            if (!string.IsNullOrEmpty(usr.correo) && !string.IsNullOrEmpty(usr.nombre) && 
                !string.IsNullOrEmpty(usr.apellido)&& !string.IsNullOrEmpty(usr.contrasena))
            {
                db.Usuario.Add(usr);
                db.SaveChanges();
                db.Dispose();
            }

            return RedirectToAction("Index", "Inicio");
        }
    }
}
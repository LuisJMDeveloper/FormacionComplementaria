using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using CAPA_CORDINADOR.Controllers;
using CAPA_ENTITY;

 


namespace CAPA_LOGIN.Controllers
{
    public class HomeLoginController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CapaCoordinador()
        {
            ReporteController reporteController = new ReporteController();
            return reporteController.IndexReporte();
        }

        [HttpPost]
        public ActionResult Ingresar(string usuario, string clave)
        {
            using (FC_CIP_pruebaEntities1 db = new FC_CIP_pruebaEntities1())
            {
                Decimal Usuario = Convert.ToDecimal(usuario);
                var persona = db.Database.SqlQuery<USUARIO>("EXEC getUser").ToList();

                return Json(new {persona}, JsonRequestBehavior.AllowGet);
            }
        }

    }
}
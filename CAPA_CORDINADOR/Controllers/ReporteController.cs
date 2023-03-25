using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CAPA_ENTITY.ModelEntity;
using CAPA_ENTITY.ViewModels;

namespace CAPA_CORDINADOR.Controllers
{
    public class ReporteController : Controller
    {
        // GET: Reporte
        public ActionResult IndexReporte()
        {
            return View();
        }

        [HttpGet]
        public JsonResult getSolicitudesRecibidas()
        {
            
            using (var db = new FC_DB())
            {
                var oLista = db.Database.SqlQuery<getSolicitudesRecibidas>("EXEC getSolicitudesRecibidas").ToList();
                return Json( new { data = oLista }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}
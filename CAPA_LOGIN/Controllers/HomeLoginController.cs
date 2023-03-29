using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using CAPA_CORDINADOR.Controllers;

 


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

    }
}
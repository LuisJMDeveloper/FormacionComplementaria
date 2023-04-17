using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using CAPA_CORDINADOR.Controllers;
using CAPA_ENTITY.ModelEntity;

 


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
            /*
            using (var db = new FC_DB())
            {
                
               var persona = from user in db.USUARIO
                where user.us_nid == Convert.ToDecimal(usuario) 
                    && user.us_password == clave && user.us_typeuser == "Instructor"
                select user;

                if(persona.Count() > 0)
                {
                    return Json(persona);
                }
            }*/

            if(usuario == "123" && clave == "a")
            {
                return Content("1");
            }else if(usuario == "321" && clave == "a"){
                return Content("2");
            }
            else
            {
                return Content("3");
            }
            
        }

    }
}
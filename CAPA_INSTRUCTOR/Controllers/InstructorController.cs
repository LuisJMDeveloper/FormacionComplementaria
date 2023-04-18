using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClassLibrary1.Datos;
using ClassLibrary1.Logica;

namespace CAPA_INSTRUCTOR.Controllers
{
    public class InstructorController : Controller
    {
        // GET: Instructor
        public ActionResult InstructorIndex()
        {
            return View();
        }

        public JsonResult GuardarSolicitud(SolicitudCurso oGuardado)
        {
            return Json(new { data = oGuardado }, JsonRequestBehavior.AllowGet);
        }
    }
}
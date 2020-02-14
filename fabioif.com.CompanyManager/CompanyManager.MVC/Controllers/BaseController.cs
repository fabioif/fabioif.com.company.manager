using CompanyManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CompanyManager.MVC.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
        protected Usuario UsuarioAutenticado
        {
            get
            {
                if (Session["UsuarioAutenticado"] == null)
                {
                    Session["UsuarioAutenticado"] = new Usuario();
                }

                return (Usuario)Session["UsuarioAutenticado"];
            }
            set
            {
                Session["UsuarioAutenticado"] = value;
            }
        }
    }
}
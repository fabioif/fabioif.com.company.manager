using CompanyManager.MVC.ViewModels;
using CompanyManager.Service.Interface;
using CompanyManager.Service.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security;
using System.Web.Security;
using System.Web.Mvc;


namespace CompanyManager.MVC.Controllers
{
    public class LoginController : BaseController
    {
        IUsuarioService usuarioService;

        public LoginController(IUsuarioService _usuarioService)
        {
            usuarioService = _usuarioService;
        }

        public LoginController()
        {
            usuarioService = new UsuarioService();
        }

        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    UsuarioAutenticado = usuarioService.Login(model.Email, model.Senha);

                    if (UsuarioAutenticado != null)
                    {
                        FormsAuthentication.SetAuthCookie(model.Email, false);

                        return RedirectToAction("Index", "Home");
                    }
                }
                catch (Exception a)
                {
                    throw (new Exception("Acesso negado", a));
                }

                return View("Index");
            }

            return View(model);
        }
    }
}
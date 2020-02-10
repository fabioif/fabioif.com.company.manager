using CompanyManager.MVC.ViewModels;
using CompanyManager.Service.Interface;
using CompanyManager.Service.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CompanyManager.MVC.Controllers
{
    public class LoginController : Controller
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

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)

                if (usuarioService.VerificarLoginExiste(model.Email, model.Senha))
                {

                    return RedirectToAction("Index", "Home");
                }
                    

            return View("Index");
        }
    }
}
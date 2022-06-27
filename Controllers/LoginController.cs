using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TccAds.Dal;
using TccAds.Models;

namespace TccAds.Controllers
{
    public class LoginController : Controller
    {

        private Contexto db = new Contexto();
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Cadastro()
        {
            return View();
        }

        public ActionResult Recuperar()
        {
            return View();
        }



        public ActionResult Create([Bind(Include = "ID,UsrNome,UsrEmail,UsrSenha,UsrData,UsrRua,UsrNum,UsrBairro,UsrCidade")] Usuarios usuarios)
        {
            if (ModelState.IsValid)
            {
                db.Usuarios.Add(usuarios);
                db.SaveChanges();
                             
              
                return RedirectToAction("Login");
            }
            
            return View(usuarios);
        }
    }
}
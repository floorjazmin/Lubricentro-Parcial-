using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Services;

namespace FrontEnd.Controllers
{
    public class UsuariosController : Controller
    {
        public ActionResult Login()
        {
            
            return View(new Usuarios());
        }

        public ActionResult Validar(Usuarios usuario)
        {
            //recibir por post el usuario y la clave
            List<Usuarios> listaUsuarios = Usuarios.Listar();
            if (listaUsuarios.Any(x => x.Email == usuario.Email && x.Clave == usuario.Clave))
            {

               return RedirectToAction("Index", "Home");
            }
            else
            { 
            return RedirectToAction("Login", "Usuarios");
            }
            }
        }
    }


﻿using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Beauty_Contest.Data;
using Beauty_Contest.Models;

namespace Beauty_Contest.Controllers
{
    public class AccesoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }



        [HttpPost]
        public async Task<IActionResult> Index(Usuario _usuario)
        {
            DA_Logica _da_usuario = new DA_Logica();

            var usuario = _da_usuario.ValidarUsuario(_usuario.Correo, _usuario.Clave);

            if (usuario != null)
            {

                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name ,usuario.Nombre),
                    new Claim("correo", usuario.Correo)
                };

                foreach (string rol in usuario.Roles)
                {
                    claims.Add(new Claim(ClaimTypes.Role, rol));
                }

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));



                return RedirectToAction("Index", "Home");
            }
            else
            {

                return View();
            }
        }




        public async Task<IActionResult> Salir()
        {

            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction("Index", "Acceso");
        }




    }
}

    
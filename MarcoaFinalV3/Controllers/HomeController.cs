﻿using MarcoaFinalV3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MarcoaFinalV3.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        private static Usuario SesionUsuario;
        public ActionResult IndexAdmin()
        {
            if (Session["Usuario"] != null)
                SesionUsuario = (Usuario)Session["Usuario"];
            else
            {
                SesionUsuario = new Usuario();
            }
            try
            {
                ViewBag.NombreUsuario = SesionUsuario.Nombres + " " + SesionUsuario.Apellidos;
                ViewBag.RolUsuario = SesionUsuario.oRol.Descripcion;

            }
            catch
            {

            }


            return View();
        }
        public ActionResult IndexCocinero()
        {
            if (Session["Usuario"] != null)
                SesionUsuario = (Usuario)Session["Usuario"];
            else
            {
                SesionUsuario = new Usuario();
            }
            try
            {
                ViewBag.NombreUsuario = SesionUsuario.Nombres + " " + SesionUsuario.Apellidos;
                ViewBag.RolUsuario = SesionUsuario.oRol.Descripcion;

            }
            catch
            {

            }


            return View();
        }
        public ActionResult IndexVendedor()
        {
            if (Session["Usuario"] != null)
                SesionUsuario = (Usuario)Session["Usuario"];
            else
            {
                SesionUsuario = new Usuario();
            }
            try
            {
                ViewBag.NombreUsuario = SesionUsuario.Nombres + " " + SesionUsuario.Apellidos;
                ViewBag.RolUsuario = SesionUsuario.oRol.Descripcion;

            }
            catch
            {

            }


            return View();
        }

        public ActionResult Salir()
        {
            Session["Usuario"] = null;
            return RedirectToAction("Index", "Login");
        }

    }
}
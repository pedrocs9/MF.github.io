﻿using MarcoaFinalV3.Controllers;
using MarcoaFinalV3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MarcoaFinalV3.Filters
{
    public class VerificarSession : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {

            Usuario oUsuario = (Usuario)HttpContext.Current.Session["Usuario"];

            if (oUsuario == null)
            {

                if (filterContext.Controller is LoginController == false)
                {
                    filterContext.HttpContext.Response.Redirect("~/Login/Index");
                }
            }
            else
            {

                if (filterContext.Controller is LoginController == true)
                {
                    filterContext.HttpContext.Response.Redirect("~/Home/IndexAdmin");
                }
            }


            base.OnActionExecuting(filterContext);
        }

    }
}
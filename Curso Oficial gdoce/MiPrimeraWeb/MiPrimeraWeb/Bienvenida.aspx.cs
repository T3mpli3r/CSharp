﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MiPrimeraWeb
{
    public partial class Bienvenida : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            recogeNombre.InnerText = Request.Form["txtNombre"];
            recogeCiudad.InnerText = Request.Form["txtCiudad"];
        }
    }
}
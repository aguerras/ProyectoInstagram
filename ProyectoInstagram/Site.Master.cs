﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoInstagram
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_cerrarSesion(object sender, EventArgs e)
        {
            Session["id_usuario"] = null;
            Response.Redirect("/Profile-edit.aspx");
        }
    }
}
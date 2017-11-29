﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UTN
{
    public partial class CerrarSesion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["user"] = null;
            Session.Abandon();
            Session.Clear();
            Session.RemoveAll();
            Response.AddHeader("REFRESH", "5;URL=default.aspx");
        }
    }
}
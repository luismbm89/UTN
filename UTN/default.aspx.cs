using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UTN
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) {
                try
                {
                    lblUser.Text = "Bienvenido(a) "+Session["user"].ToString();
                }
                catch (Exception ex) { } 
            }

        }
    }
}
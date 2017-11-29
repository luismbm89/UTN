using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UTN
{
    public partial class template : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"]==null) {
                char cd = (char)34;
                Literal1.Text = "<a class="+ cd+"nav-link"+cd+" href ="+cd+"#" + cd + " style =" + cd + "color:white" + cd + " id =" + cd + "myBtn" + cd + " > Entrar</a>";
            }
            else
            {
                Literal1.Text = "<a class=\"nav-link\" href =\"CerrarSesion.aspx\" style =\"color:white\" id =\"btnSalir\" > Salir</a>";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Length > 0)
            {

                Session["user"] = txtUsuario.Text;
                Response.Redirect("default.aspx");
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
            }
        }
    }
}
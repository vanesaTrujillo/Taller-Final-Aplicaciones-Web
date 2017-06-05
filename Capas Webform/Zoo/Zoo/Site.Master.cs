using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Zoo
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var inLogin = HttpContext.Current.Request.Url.LocalPath.Contains("/Usuarios/Login");
            if (Session["Usuario"]==null&&!inLogin)
            {
                Response.Redirect("~/Usuarios/Login");
            }
        }

        protected void CerrarSesion_Click(object sender, EventArgs e)
        {
            Session["Usuario"] = null;
            Response.Redirect("~/Usuarios/Login");
        }
    }
}
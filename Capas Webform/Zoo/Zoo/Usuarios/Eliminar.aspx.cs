using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Zoo.Usuarios
{
    public partial class Eliminar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = Int32.Parse(Request.QueryString["id"] ?? "0");
                UsuariosController controlador = new UsuariosController();
                var usuario = controlador.Detalle(id);
                Nombre.Text = usuario.Nombre;
            }
        }

        protected void Eliminar_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(Request.QueryString["id"] ?? "0");
            UsuariosController controlador = new UsuariosController();
            controlador.Eliminar(id);
            Response.Redirect("~/Usuarios/");
        }
    }
}
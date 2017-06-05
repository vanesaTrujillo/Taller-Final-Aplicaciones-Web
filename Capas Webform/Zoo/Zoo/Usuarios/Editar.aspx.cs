using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Zoo.Usuarios
{
    public partial class Editar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            NombreValidation.Visible = false;
            ContrasenaValidation.Visible = false;

            if (!IsPostBack)
            {
                int id = Int32.Parse(Request.QueryString["id"] ?? "0");
                UsuariosController controlador = new UsuariosController();
                var usuario = controlador.Detalle(id);
                Nombre.Text = usuario.Nombre;
                Contrasena.Text = usuario.Contrasena;
            }
        }

        protected void Editar_Click(object sender, EventArgs e)
        {
            bool valido = true;
            string obligatorio = "Este campo es obligatorio";
            Nombre.Text = (Nombre.Text ?? "").Trim();
            if (Nombre.Text.Length == 0)
            {
                valido = false;
                NombreValidation.Text = obligatorio;
                NombreValidation.Visible = true;
            }

            Contrasena.Text = (Contrasena.Text ?? "");
            if (Contrasena.Text.Length == 0)
            {
                valido = false;
                ContrasenaValidation.Text = obligatorio;
                ContrasenaValidation.Visible = true;
            }

            if (valido)
            {
                int id = Int32.Parse(Request.QueryString["id"] ?? "0");
                UsuariosController controlador = new UsuariosController();
                controlador.Editar(id, Nombre.Text, Contrasena.Text);
                Response.Redirect("~/Usuarios/");
            }
        }
    }
}
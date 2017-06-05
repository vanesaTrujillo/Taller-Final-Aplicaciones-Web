using Negocio;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Zoo.Usuarios
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            NombreValidation.Visible = false;
            ContrasenaValidation.Visible = false;
            Mensaje.Visible = false;
        }

        protected void Ingresar_Click(object sender, EventArgs e)
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
                UsuariosController controlador = new UsuariosController();
                var usuario = controlador.ConsultarPorUserPass(Nombre.Text, Contrasena.Text);
                if (usuario == null)
                {
                    Mensaje.Text = "Usuario o contraseña incorrectos.";
                    return;
                }
                Session["Usuario"] = usuario;
                Response.Redirect("~/");
            }
        }
    }
}
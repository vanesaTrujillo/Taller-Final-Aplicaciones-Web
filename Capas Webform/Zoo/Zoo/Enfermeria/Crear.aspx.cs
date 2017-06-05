using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Zoo.Enfermeria
{
    public partial class Crear : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            AnimalValidation.Visible = false;
            DiagnosticoValidation.Visible = false;
        }

        protected void Crear_Click(object sender, EventArgs e)
        {
            bool valido = true;
            string obligatorio = "Este campo es obligatorio";
            Animal.Text = (Animal.Text ?? "").Trim();
            if (Animal.Text.Length == 0)
            {
                valido = false;
                AnimalValidation.Text = obligatorio;
                AnimalValidation.Visible = true;
            }

            Diagnostico.Text = (Diagnostico.Text ?? "").Trim();
            if (Diagnostico.Text.Length == 0)
            {
                valido = false;
                DiagnosticoValidation.Text = obligatorio;
                DiagnosticoValidation.Visible = true;
            }

            if (valido)
            {
                EnfermeriaController controlador = new EnfermeriaController();
                controlador.Crear(Int32.Parse(Animal.SelectedValue), Diagnostico.Text);
                Response.Redirect("~/Enfermeria/");
            }
        }
    }
}
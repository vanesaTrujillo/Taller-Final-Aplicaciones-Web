using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Zoo.Animales
{
    public partial class Crear : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            NombreValidation.Visible = false;
            EdadValidation.Visible = false;
            PaisOrigenValidation.Visible = false;
            EspecieValidation.Visible = false;
            SubespecieValidation.Visible = false;
            CostumbresAlimenticiasValidation.Visible = false;
            TipoValidation.Visible = false;
        }

        protected void Crear_Click(object sender, EventArgs e)
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

            Edad.Text = (Edad.Text ?? "").Trim();
            if (Edad.Text.Length == 0)
            {
                valido = false;
                EdadValidation.Text = obligatorio;
                EdadValidation.Visible = true;
            }

            PaisOrigen.Text = (PaisOrigen.Text ?? "").Trim();
            if (PaisOrigen.Text.Length == 0)
            {
                valido = false;
                PaisOrigenValidation.Text = obligatorio;
                PaisOrigenValidation.Visible = true;
            }

            Especie.Text = (Especie.Text ?? "").Trim();
            if (Especie.Text.Length == 0)
            {
                valido = false;
                EspecieValidation.Text = obligatorio;
                EspecieValidation.Visible = true;
            }

            Subespecie.Text = (Subespecie.Text ?? "").Trim();
            if (Subespecie.Text.Length == 0)
            {
                valido = false;
                SubespecieValidation.Text = obligatorio;
                SubespecieValidation.Visible = true;
            }

            CostumbresAlimenticias.Text = (CostumbresAlimenticias.Text ?? "").Trim();
            if (CostumbresAlimenticias.Text.Length == 0)
            {
                valido = false;
                CostumbresAlimenticiasValidation.Text = obligatorio;
                CostumbresAlimenticiasValidation.Visible = true;
            }

            Tipo.Text = (Tipo.Text ?? "").Trim();
            if (Tipo.Text.Length == 0)
            {
                valido = false;
                TipoValidation.Text = obligatorio;
                TipoValidation.Visible = true;
            }

            if (valido)
            {
                AnimalesController controlador = new AnimalesController();
                controlador.Crear(Nombre.Text, Int32.Parse(Edad.Text), PaisOrigen.Text, Especie.Text, Subespecie.Text, CostumbresAlimenticias.Text, Tipo.Text);
                Response.Redirect("~/Animales/");
            }

        }
    }
}
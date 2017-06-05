using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Zoo.Animales
{
    public partial class Eliminar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = Int32.Parse(Request.QueryString["id"] ?? "0");
                AnimalesController controlador = new AnimalesController();
                var animal = controlador.Detalle(id);
                Nombre.Text = animal.Nombre;
                Edad.Text = animal.Edad.ToString();
                PaisOrigen.Text = animal.PaisOrigen;
                Especie.Text = animal.Especie;
                Subespecie.Text = animal.Subespecie;
                CostumbresAlimenticias.Text = animal.CostumbresAlimenticias;
                Tipo.Text = animal.Tipo;
            }
        }

        protected void Eliminar_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(Request.QueryString["id"] ?? "0");
            AnimalesController controlador = new AnimalesController();
            controlador.Eliminar(id);
            Response.Redirect("~/Animales/");
        }
    }
}
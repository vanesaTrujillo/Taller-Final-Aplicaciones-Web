using Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Zoo.Reporte
{
    public partial class Default1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Exportar_Click(object sender, EventArgs e)
        {
            ReporteController controlador = new ReporteController();
            var animales = new DataTable("animales");
            var animalesEnEnfermeria = controlador.Consultar();
            animales.Columns.Add("Nombre", typeof(string));
            animales.Columns.Add("Edad", typeof(string));
            animales.Columns.Add("Fecha Ingreso", typeof(string));
            animales.Columns.Add("Diagnóstico", typeof(string));
            foreach (var item in animalesEnEnfermeria)
            {
                animales.Rows.Add(item.Nombre, item.Edad, item.FechaIngreso.ToShortDateString() + " " + item.FechaIngreso.ToShortTimeString(), item.Diagnostico);
            }

            var grid = new GridView();
            grid.DataSource = animales;
            grid.DataBind();

            Response.ClearContent();
            Response.Buffer = true;
            Response.AddHeader("content-disposition", "attachment; filename=MyExcelFile.xls");
            Response.ContentType = "application/ms-excel";
            Response.Charset = "utf-8";

            StringWriter sw = new StringWriter();
            HtmlTextWriter htw = new HtmlTextWriter(sw);
            grid.RenderControl(htw);
            Response.Output.Write(sw.ToString());
            Response.Flush();
            Response.End();
        }
    }
}
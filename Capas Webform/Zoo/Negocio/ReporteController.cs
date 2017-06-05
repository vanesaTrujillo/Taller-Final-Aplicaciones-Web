using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ReporteController
    {
        public List<Reporte> Consultar()
        {
            using (var db = new db_zoologicoEntities())
            {
                return db.Reporte.ToList();
            }
        }
    }
}

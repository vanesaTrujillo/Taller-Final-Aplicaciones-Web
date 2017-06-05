using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class EnfermeriaController
    {
        public List<Enfermeria> Consultar()
        {
            using (var db = new db_zoologicoEntities())
            {
                return db.Enfermeria.Include("Animales").ToList();
            }
        }

        public bool Crear(int idAnimal, string diagnostico)
        {
            using (var db = new db_zoologicoEntities())
            {
                try
                {
                    Enfermeria enfermeria = new Enfermeria();
                    enfermeria.IdAnimal = idAnimal;
                    enfermeria.Diagnostico = diagnostico;
                    enfermeria.FechaIngreso = DateTime.Now;
                    db.Enfermeria.Add(enfermeria);
                    return db.SaveChanges() > 0;
                }
                catch (Exception)
                {

                    return false;
                }
                
            }
        }
    }
}

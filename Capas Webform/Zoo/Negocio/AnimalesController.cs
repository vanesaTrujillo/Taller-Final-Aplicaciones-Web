using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class AnimalesController
    {

        public List<Animales> Consultar()
        {
            using (var db = new db_zoologicoEntities())
            {
                return db.Animales.ToList();
            }
        }

        public Animales Detalle(int id)
        {
            using (var db = new db_zoologicoEntities())
            {
                return db.Animales.FirstOrDefault(a => a.Id == id);
            }
        }

        public bool Crear(string nombre, int edad, string paisOrigen, string especie, string subespecie, string costumbresAlimenticias, string tipo)
        {
            using (var db = new db_zoologicoEntities())
            {
                try
                {
                    Animales animal = new Animales();
                    animal.Nombre = nombre;
                    animal.Edad = edad;
                    animal.PaisOrigen = paisOrigen;
                    animal.Especie = especie;
                    animal.Subespecie = subespecie;
                    animal.CostumbresAlimenticias = costumbresAlimenticias;
                    animal.Tipo = tipo;
                    db.Animales.Add(animal);
                    return db.SaveChanges() > 0;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool Editar(int id, string nombre, int edad, string paisOrigen, string especie, string subespecie, string costumbresAlimenticias, string tipo)
        {
            using (var db = new db_zoologicoEntities())
            {
                try
                {
                    Animales animal = new Animales();
                    animal.Id = id;
                    animal.Nombre = nombre;
                    animal.Edad = edad;
                    animal.PaisOrigen = paisOrigen;
                    animal.Especie = especie;
                    animal.Subespecie = subespecie;
                    animal.CostumbresAlimenticias = costumbresAlimenticias;
                    animal.Tipo = tipo;
                    db.Entry(animal).State = EntityState.Modified;
                    return db.SaveChanges() > 0;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool Eliminar(int id)
        {
            using (var db = new db_zoologicoEntities())
            {
                try
                {
                    Animales animal = db.Animales.Find(id);
                    db.Animales.Remove(animal);
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

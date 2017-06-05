using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class UsuariosController
    {
        public List<Usuarios> Consultar()
        {
            using (var db = new db_zoologicoEntities())
            {
                return db.Usuarios.ToList();
            }
        }

        public Usuarios ConsultarPorUserPass(string nombre, string contrasena)
        {
            using (var db = new db_zoologicoEntities())
            {
                return db.Usuarios.FirstOrDefault(u => u.Nombre == nombre && u.Contrasena == contrasena);
            }
        }

        public Usuarios Detalle(int id)
        {
            using (var db = new db_zoologicoEntities())
            {
                return db.Usuarios.FirstOrDefault(a => a.Id == id);
            }
        }

        public bool Crear(string nombre, string contrasena)
        {
            try
            {
                using (var db = new db_zoologicoEntities())
                {
                    Usuarios usuario = new Usuarios();
                    usuario.Nombre = nombre;
                    usuario.Contrasena = contrasena;
                    db.Usuarios.Add(usuario);
                    return db.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Editar(int id, string nombre, string contrasena)
        {
            try
            {
                using (var db = new db_zoologicoEntities())
                {
                    Usuarios usuario = new Usuarios();
                    usuario.Id = id;
                    usuario.Nombre = nombre;
                    usuario.Contrasena = contrasena;
                    db.Entry(usuario).State = EntityState.Modified;
                    return db.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Eliminar(int id)
        {
            using (var db = new db_zoologicoEntities())
            {
                Usuarios usuario = db.Usuarios.Find(id);
                db.Usuarios.Remove(usuario);
                return db.SaveChanges() > 0;
            }
        }
    }
}

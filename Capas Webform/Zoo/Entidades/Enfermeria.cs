//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class Enfermeria
    {
        public int Id { get; set; }
        public int IdAnimal { get; set; }
        public System.DateTime FechaIngreso { get; set; }
        public string Diagnostico { get; set; }
    
        public virtual Animales Animales { get; set; }
    }
}

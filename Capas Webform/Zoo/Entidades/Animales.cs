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
    
    public partial class Animales
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Animales()
        {
            this.Enfermeria = new HashSet<Enfermeria>();
        }
    
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string PaisOrigen { get; set; }
        public string Especie { get; set; }
        public string Subespecie { get; set; }
        public string CostumbresAlimenticias { get; set; }
        public string Tipo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Enfermeria> Enfermeria { get; set; }
    }
}

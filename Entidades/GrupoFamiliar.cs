namespace Entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Personal.GrupoFamiliar")]
    public partial class GrupoFamiliar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GrupoFamiliar()
        {
            Persona = new HashSet<Persona>();
            PersonaServicio = new HashSet<PersonaServicio>();
        }

        public int Id { get; set; }

        public DateTime? FechaRegistro { get; set; }

        public int? Localidad { get; set; }

        public int? Barrio { get; set; }

        [StringLength(255)]
        public string Estrato { get; set; }

        [StringLength(255)]
        public string Direccion { get; set; }

        public int? Entidad { get; set; }

        public int? Usuario { get; set; }

        public virtual Barrio Barrio1 { get; set; }

        public virtual Entidad Entidad1 { get; set; }

        public virtual Localidad Localidad1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Persona> Persona { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonaServicio> PersonaServicio { get; set; }
    }
}

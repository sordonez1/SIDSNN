namespace Entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Personal.PersonaServicio")]
    public partial class PersonaServicio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PersonaServicio()
        {
            ServicioMetaData = new HashSet<ServicioMetaData>();
        }

        public int Id { get; set; }

        public DateTime? FechaRegistro { get; set; }

        public bool? Estado { get; set; }

        public int? Persona { get; set; }

        public int? Servicio { get; set; }

        public int? Entidad { get; set; }

        public int? GrupoFamiliar { get; set; }

        public int? Usuario { get; set; }

        public virtual Entidad Entidad1 { get; set; }

        public virtual Servicio Servicio1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServicioMetaData> ServicioMetaData { get; set; }

        public virtual GrupoFamiliar GrupoFamiliar1 { get; set; }
    }
}

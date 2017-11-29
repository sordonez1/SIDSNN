namespace Entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Administracion.Upz")]
    public partial class Upz
    {
        public int Id { get; set; }

        [StringLength(255)]
        public string Nombre { get; set; }

        public int? Localidad { get; set; }

        public long? Estado { get; set; }

        public virtual Localidad Localidad1 { get; set; }
    }
}

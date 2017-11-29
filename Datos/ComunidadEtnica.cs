namespace Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Administracion.ComunidadEtnica")]
    public partial class ComunidadEtnica
    {
        public int Id { get; set; }

        [StringLength(255)]
        public string Nombre { get; set; }

        public int? Etnia { get; set; }

        public bool? Estado { get; set; }

        public virtual Etnia Etnia1 { get; set; }
    }
}

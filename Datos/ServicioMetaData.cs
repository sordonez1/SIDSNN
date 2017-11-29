namespace Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Administracion.ServicioMetaData")]
    public partial class ServicioMetaData
    {
        public int Id { get; set; }

        [StringLength(255)]
        public string Valor { get; set; }

        public int? PersonaServicio { get; set; }

        public int? TipoServicioParametro { get; set; }

        public virtual PersonaServicio PersonaServicio1 { get; set; }

        public virtual TipoServicioParametro TipoServicioParametro1 { get; set; }
    }
}

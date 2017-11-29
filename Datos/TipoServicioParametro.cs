namespace Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Administracion.TipoServicioParametro")]
    public partial class TipoServicioParametro
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoServicioParametro()
        {
            ServicioMetaData = new HashSet<ServicioMetaData>();
        }

        public int Id { get; set; }

        [StringLength(255)]
        public string Label { get; set; }

        [StringLength(255)]
        public string Valores { get; set; }

        public bool? Estado { get; set; }

        public int? Servicio { get; set; }

        [StringLength(255)]
        public string Tipo { get; set; }

        [StringLength(255)]
        public string Campo { get; set; }

        public int? Orden { get; set; }

        public bool? Obligatorio { get; set; }

        [StringLength(255)]
        public string Mensaje { get; set; }

        [StringLength(255)]
        public string ValorCampo { get; set; }

        public virtual Servicio Servicio1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServicioMetaData> ServicioMetaData { get; set; }
    }
}

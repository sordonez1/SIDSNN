namespace Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Personal.Persona")]
    public partial class Persona
    {
        public int Id { get; set; }

        [StringLength(255)]
        public string NumeroIdentificacion { get; set; }

        [StringLength(255)]
        public string PrimerNombre { get; set; }

        [StringLength(255)]
        public string SegundoNombre { get; set; }

        [StringLength(255)]
        public string PrimerApellido { get; set; }

        [StringLength(255)]
        public string SegundoApellido { get; set; }

        public DateTime? FechaNacimiento { get; set; }

        public int? CiudadNacimiento { get; set; }

        [StringLength(255)]
        public string Telefono { get; set; }

        [StringLength(255)]
        public string Celular { get; set; }

        [StringLength(255)]
        public string Email { get; set; }

        public DateTime? FechaRegistro { get; set; }

        public int? EntidadRegistra { get; set; }

        public int? UsuarioRegistra { get; set; }

        public int? TipoDocumento { get; set; }

        public int? Parentesco { get; set; }

        public int? Sexo { get; set; }

        public int? Etnia { get; set; }

        public int? Genero { get; set; }

        public int? OrientacionSexual { get; set; }

        public int? EstadoCivil { get; set; }

        public int? SistemaSalud { get; set; }

        public int? NivelEducativo { get; set; }

        public bool? Estado { get; set; }

        public int? GrupoFamiliar { get; set; }

        public int? Eps { get; set; }

        public int? Rh { get; set; }

        public virtual Eps Eps1 { get; set; }

        public virtual EstadoCivil EstadoCivil1 { get; set; }

        public virtual Etnia Etnia1 { get; set; }

        public virtual Genero Genero1 { get; set; }

        public virtual NivelEducativo NivelEducativo1 { get; set; }

        public virtual OrientacionSexual OrientacionSexual1 { get; set; }

        public virtual Parentesco Parentesco1 { get; set; }

        public virtual Rh Rh1 { get; set; }

        public virtual Sexo Sexo1 { get; set; }

        public virtual SistemaSalud SistemaSalud1 { get; set; }

        public virtual TipoDocumento TipoDocumento1 { get; set; }

        public virtual GrupoFamiliar GrupoFamiliar1 { get; set; }
    }
}

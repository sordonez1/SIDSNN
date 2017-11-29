namespace Entidades
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Modelo : DbContext
    {
        public Modelo()
            : base("name=Modelo")
        {
        }

        public virtual DbSet<Barrio> Barrio { get; set; }
        public virtual DbSet<Ciudad> Ciudad { get; set; }
        public virtual DbSet<ComunidadEtnica> ComunidadEtnica { get; set; }
        public virtual DbSet<Departamento> Departamento { get; set; }
        public virtual DbSet<Entidad> Entidad { get; set; }
        public virtual DbSet<Eps> Eps { get; set; }
        public virtual DbSet<EstadoCivil> EstadoCivil { get; set; }
        public virtual DbSet<Etnia> Etnia { get; set; }
        public virtual DbSet<Genero> Genero { get; set; }
        public virtual DbSet<GrupoSanguineo> GrupoSanguineo { get; set; }
        public virtual DbSet<Localidad> Localidad { get; set; }
        public virtual DbSet<NivelEducativo> NivelEducativo { get; set; }
        public virtual DbSet<OrientacionSexual> OrientacionSexual { get; set; }
        public virtual DbSet<Pais> Pais { get; set; }
        public virtual DbSet<Parentesco> Parentesco { get; set; }
        public virtual DbSet<Rh> Rh { get; set; }
        public virtual DbSet<Servicio> Servicio { get; set; }
        public virtual DbSet<ServicioMetaData> ServicioMetaData { get; set; }
        public virtual DbSet<Sexo> Sexo { get; set; }
        public virtual DbSet<SistemaSalud> SistemaSalud { get; set; }
        public virtual DbSet<TipoDocumento> TipoDocumento { get; set; }
        public virtual DbSet<TipoServicioParametro> TipoServicioParametro { get; set; }
        public virtual DbSet<Upz> Upz { get; set; }
        public virtual DbSet<GrupoFamiliar> GrupoFamiliar { get; set; }
        public virtual DbSet<Persona> Persona { get; set; }
        public virtual DbSet<PersonaServicio> PersonaServicio { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Barrio>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Barrio>()
                .HasMany(e => e.GrupoFamiliar)
                .WithOptional(e => e.Barrio1)
                .HasForeignKey(e => e.Barrio);

            modelBuilder.Entity<Ciudad>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Ciudad>()
                .HasMany(e => e.Localidad)
                .WithOptional(e => e.Ciudad1)
                .HasForeignKey(e => e.Ciudad);

            modelBuilder.Entity<ComunidadEtnica>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Departamento>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Departamento>()
                .Property(e => e.CodigoDane)
                .IsUnicode(false);

            modelBuilder.Entity<Departamento>()
                .HasMany(e => e.Ciudad)
                .WithOptional(e => e.Departamento1)
                .HasForeignKey(e => e.Departamento);

            modelBuilder.Entity<Entidad>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Entidad>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Entidad>()
                .HasMany(e => e.GrupoFamiliar)
                .WithOptional(e => e.Entidad1)
                .HasForeignKey(e => e.Entidad);

            modelBuilder.Entity<Entidad>()
                .HasMany(e => e.PersonaServicio)
                .WithOptional(e => e.Entidad1)
                .HasForeignKey(e => e.Entidad);

            modelBuilder.Entity<Eps>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Eps>()
                .HasMany(e => e.Persona)
                .WithOptional(e => e.Eps1)
                .HasForeignKey(e => e.Eps);

            modelBuilder.Entity<EstadoCivil>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<EstadoCivil>()
                .HasMany(e => e.Persona)
                .WithOptional(e => e.EstadoCivil1)
                .HasForeignKey(e => e.EstadoCivil);

            modelBuilder.Entity<Etnia>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Etnia>()
                .Property(e => e.NombreCategoriaEtnica)
                .IsUnicode(false);

            modelBuilder.Entity<Etnia>()
                .HasMany(e => e.ComunidadEtnica)
                .WithOptional(e => e.Etnia1)
                .HasForeignKey(e => e.Etnia);

            modelBuilder.Entity<Etnia>()
                .HasMany(e => e.Persona)
                .WithOptional(e => e.Etnia1)
                .HasForeignKey(e => e.Etnia);

            modelBuilder.Entity<Genero>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Genero>()
                .HasMany(e => e.Persona)
                .WithOptional(e => e.Genero1)
                .HasForeignKey(e => e.Genero);

            modelBuilder.Entity<GrupoSanguineo>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<GrupoSanguineo>()
                .HasMany(e => e.Rh)
                .WithOptional(e => e.GrupoSanguineo1)
                .HasForeignKey(e => e.GrupoSanguineo);

            modelBuilder.Entity<Localidad>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Localidad>()
                .HasMany(e => e.GrupoFamiliar)
                .WithOptional(e => e.Localidad1)
                .HasForeignKey(e => e.Localidad);

            modelBuilder.Entity<Localidad>()
                .HasMany(e => e.Upz)
                .WithOptional(e => e.Localidad1)
                .HasForeignKey(e => e.Localidad);

            modelBuilder.Entity<NivelEducativo>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<NivelEducativo>()
                .HasMany(e => e.Persona)
                .WithOptional(e => e.NivelEducativo1)
                .HasForeignKey(e => e.NivelEducativo);

            modelBuilder.Entity<OrientacionSexual>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<OrientacionSexual>()
                .HasMany(e => e.Persona)
                .WithOptional(e => e.OrientacionSexual1)
                .HasForeignKey(e => e.OrientacionSexual);

            modelBuilder.Entity<Pais>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Pais>()
                .HasMany(e => e.Departamento)
                .WithOptional(e => e.Pais1)
                .HasForeignKey(e => e.Pais);

            modelBuilder.Entity<Parentesco>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Parentesco>()
                .HasMany(e => e.Persona)
                .WithOptional(e => e.Parentesco1)
                .HasForeignKey(e => e.Parentesco);

            modelBuilder.Entity<Rh>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Rh>()
                .HasMany(e => e.Persona)
                .WithOptional(e => e.Rh1)
                .HasForeignKey(e => e.Rh);

            modelBuilder.Entity<Servicio>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Servicio>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Servicio>()
                .HasMany(e => e.PersonaServicio)
                .WithOptional(e => e.Servicio1)
                .HasForeignKey(e => e.Servicio);

            modelBuilder.Entity<Servicio>()
                .HasMany(e => e.TipoServicioParametro)
                .WithOptional(e => e.Servicio1)
                .HasForeignKey(e => e.Servicio);

            modelBuilder.Entity<ServicioMetaData>()
                .Property(e => e.Valor)
                .IsUnicode(false);

            modelBuilder.Entity<Sexo>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Sexo>()
                .HasMany(e => e.Persona)
                .WithOptional(e => e.Sexo1)
                .HasForeignKey(e => e.Sexo);

            modelBuilder.Entity<SistemaSalud>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<SistemaSalud>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<SistemaSalud>()
                .HasMany(e => e.Persona)
                .WithOptional(e => e.SistemaSalud1)
                .HasForeignKey(e => e.SistemaSalud);

            modelBuilder.Entity<TipoDocumento>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TipoDocumento>()
                .Property(e => e.Sigla)
                .IsUnicode(false);

            modelBuilder.Entity<TipoDocumento>()
                .HasMany(e => e.Persona)
                .WithOptional(e => e.TipoDocumento1)
                .HasForeignKey(e => e.TipoDocumento);

            modelBuilder.Entity<TipoServicioParametro>()
                .Property(e => e.Label)
                .IsUnicode(false);

            modelBuilder.Entity<TipoServicioParametro>()
                .Property(e => e.Valores)
                .IsUnicode(false);

            modelBuilder.Entity<TipoServicioParametro>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<TipoServicioParametro>()
                .Property(e => e.Campo)
                .IsUnicode(false);

            modelBuilder.Entity<TipoServicioParametro>()
                .Property(e => e.Mensaje)
                .IsUnicode(false);

            modelBuilder.Entity<TipoServicioParametro>()
                .Property(e => e.ValorCampo)
                .IsUnicode(false);

            modelBuilder.Entity<TipoServicioParametro>()
                .HasMany(e => e.ServicioMetaData)
                .WithOptional(e => e.TipoServicioParametro1)
                .HasForeignKey(e => e.TipoServicioParametro);

            modelBuilder.Entity<Upz>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<GrupoFamiliar>()
                .Property(e => e.Estrato)
                .IsUnicode(false);

            modelBuilder.Entity<GrupoFamiliar>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<GrupoFamiliar>()
                .HasMany(e => e.Persona)
                .WithOptional(e => e.GrupoFamiliar1)
                .HasForeignKey(e => e.GrupoFamiliar);

            modelBuilder.Entity<GrupoFamiliar>()
                .HasMany(e => e.PersonaServicio)
                .WithOptional(e => e.GrupoFamiliar1)
                .HasForeignKey(e => e.GrupoFamiliar);

            modelBuilder.Entity<Persona>()
                .Property(e => e.NumeroIdentificacion)
                .IsUnicode(false);

            modelBuilder.Entity<Persona>()
                .Property(e => e.PrimerNombre)
                .IsUnicode(false);

            modelBuilder.Entity<Persona>()
                .Property(e => e.SegundoNombre)
                .IsUnicode(false);

            modelBuilder.Entity<Persona>()
                .Property(e => e.PrimerApellido)
                .IsUnicode(false);

            modelBuilder.Entity<Persona>()
                .Property(e => e.SegundoApellido)
                .IsUnicode(false);

            modelBuilder.Entity<Persona>()
                .Property(e => e.Telefono)
                .IsUnicode(false);

            modelBuilder.Entity<Persona>()
                .Property(e => e.Celular)
                .IsUnicode(false);

            modelBuilder.Entity<Persona>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<PersonaServicio>()
                .HasMany(e => e.ServicioMetaData)
                .WithOptional(e => e.PersonaServicio1)
                .HasForeignKey(e => e.PersonaServicio);
        }
    }
}

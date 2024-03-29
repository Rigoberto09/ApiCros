namespace ApiCros.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Cliente")
        {
        }

        public virtual DbSet<clientes> clientes { get; set; }
        public virtual DbSet<cuentas_clientes> cuentas_clientes { get; set; }
        public virtual DbSet<MSreplication_options> MSreplication_options { get; set; }
        public virtual DbSet<spt_fallback_db> spt_fallback_db { get; set; }
        public virtual DbSet<spt_fallback_dev> spt_fallback_dev { get; set; }
        public virtual DbSet<spt_fallback_usg> spt_fallback_usg { get; set; }
        public virtual DbSet<spt_monitor> spt_monitor { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<clientes>()
                .Property(e => e.primer_nombre)
                .IsUnicode(false);

            modelBuilder.Entity<clientes>()
                .Property(e => e.segundo_nombre)
                .IsUnicode(false);

            modelBuilder.Entity<clientes>()
                .Property(e => e.primer_apellido)
                .IsUnicode(false);

            modelBuilder.Entity<clientes>()
                .Property(e => e.segundo_apellido)
                .IsUnicode(false);

            modelBuilder.Entity<clientes>()
                .Property(e => e.direccion)
                .IsUnicode(false);

            modelBuilder.Entity<clientes>()
                .Property(e => e.telefono)
                .IsUnicode(false);

            modelBuilder.Entity<clientes>()
                .Property(e => e.correo)
                .IsUnicode(false);

            modelBuilder.Entity<clientes>()
                .Property(e => e.usuario_creo)
                .IsUnicode(false);

            modelBuilder.Entity<clientes>()
                .Property(e => e.usuario_borro)
                .IsUnicode(false);

            modelBuilder.Entity<cuentas_clientes>()
                .Property(e => e.tipo_cuenta)
                .IsUnicode(false);

            modelBuilder.Entity<cuentas_clientes>()
                .Property(e => e.detalle)
                .IsUnicode(false);

            modelBuilder.Entity<spt_fallback_db>()
                .Property(e => e.xserver_name)
                .IsUnicode(false);

            modelBuilder.Entity<spt_fallback_db>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<spt_fallback_dev>()
                .Property(e => e.xserver_name)
                .IsUnicode(false);

            modelBuilder.Entity<spt_fallback_dev>()
                .Property(e => e.xfallback_drive)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<spt_fallback_dev>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<spt_fallback_dev>()
                .Property(e => e.phyname)
                .IsUnicode(false);

            modelBuilder.Entity<spt_fallback_usg>()
                .Property(e => e.xserver_name)
                .IsUnicode(false);
        }
    }
}

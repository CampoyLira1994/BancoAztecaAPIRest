namespace ApiRestBancoAzteca.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BancoAzteca : DbContext
    {
        public BancoAzteca()
            : base("name=BancoAzteca")
        {
        }

        public virtual DbSet<Empleados> Empleados { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Empleados>()
                .Property(e => e.Nombres)
                .IsUnicode(false);

            modelBuilder.Entity<Empleados>()
                .Property(e => e.ApellidoPaterno)
                .IsUnicode(false);

            modelBuilder.Entity<Empleados>()
                .Property(e => e.ApellidoMaterno)
                .IsUnicode(false);

            modelBuilder.Entity<Empleados>()
                .Property(e => e.Genero)
                .IsUnicode(false);

            modelBuilder.Entity<Empleados>()
                .Property(e => e.Documento)
                .IsUnicode(false);
        }
    }
}

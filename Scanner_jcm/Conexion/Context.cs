using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Scanner_jcm.Models
{
    public partial class Context : DbContext
    {
        public Context()
            : base("name=Context")
        {
        }

        public virtual DbSet<registroAcceso> registroAcceso { get; set; }
        public virtual DbSet<usuario> usuario { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<registroAcceso>()
                .Property(e => e.usuario)
                .IsUnicode(false);

            modelBuilder.Entity<registroAcceso>()
                .Property(e => e.dni)
                .IsUnicode(false);

            modelBuilder.Entity<usuario>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<usuario>()
                .Property(e => e.apellido)
                .IsUnicode(false);

            modelBuilder.Entity<usuario>()
                .Property(e => e.telefono)
                .IsUnicode(false);

            modelBuilder.Entity<usuario>()
                .Property(e => e.dni)
                .IsUnicode(false);
        }
    }
}

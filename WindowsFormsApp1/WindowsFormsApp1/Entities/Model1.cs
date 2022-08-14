using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WindowsFormsApp1.Entities
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Birimler> Birimler { get; set; }
        public virtual DbSet<Personeller> Personeller { get; set; }
        public virtual DbSet<viewPersonelBirim> viewPersonelBirim { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Birimler>()
                .Property(e => e.BirimAdi)
                .IsUnicode(false);

            modelBuilder.Entity<Birimler>()
                .Property(e => e.Aciklama)
                .IsUnicode(false);

            modelBuilder.Entity<Personeller>()
                .Property(e => e.AdiSoyadi)
                .IsUnicode(false);

            modelBuilder.Entity<Personeller>()
                .Property(e => e.Telefon)
                .IsUnicode(false);

            modelBuilder.Entity<Personeller>()
                .Property(e => e.Adres)
                .IsUnicode(false);

            modelBuilder.Entity<viewPersonelBirim>()
                .Property(e => e.AdiSoyadi)
                .IsUnicode(false);

            modelBuilder.Entity<viewPersonelBirim>()
                .Property(e => e.Telefon)
                .IsUnicode(false);

            modelBuilder.Entity<viewPersonelBirim>()
                .Property(e => e.Adres)
                .IsUnicode(false);

            modelBuilder.Entity<viewPersonelBirim>()
                .Property(e => e.BirimAdi)
                .IsUnicode(false);
        }
    }
}

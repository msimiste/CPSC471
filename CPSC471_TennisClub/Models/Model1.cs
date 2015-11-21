namespace CPSC471_TennisClub.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<member> members { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<member>()
                .Property(e => e.rating)
                .IsUnicode(false);

            modelBuilder.Entity<member>()
                .Property(e => e.phonenumber)
                .IsUnicode(false);

            modelBuilder.Entity<member>()
                .Property(e => e.firstname)
                .IsUnicode(false);

            modelBuilder.Entity<member>()
                .Property(e => e.middlename)
                .IsUnicode(false);

            modelBuilder.Entity<member>()
                .Property(e => e.lastname)
                .IsUnicode(false);

            modelBuilder.Entity<member>()
                .Property(e => e.streetname)
                .IsUnicode(false);

            modelBuilder.Entity<member>()
                .Property(e => e.streetnum)
                .IsUnicode(false);

            modelBuilder.Entity<member>()
                .Property(e => e.postalCode)
                .IsUnicode(false);

            modelBuilder.Entity<member>()
                .Property(e => e.city)
                .IsUnicode(false);
        }
    }
}

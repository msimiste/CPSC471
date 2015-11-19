namespace ReverseEng
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model2 : DbContext
    {
        public Model2()
            : base("name=Model23")
        {
        }

       // public virtual DbSet<address> addresses { get; set; }

      /*  protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<address>()
                .Property(e => e.address1)
                .IsUnicode(false);

            modelBuilder.Entity<address>()
                .Property(e => e.address2)
                .IsUnicode(false);

            modelBuilder.Entity<address>()
                .Property(e => e.district)
                .IsUnicode(false);

            modelBuilder.Entity<address>()
                .Property(e => e.postal_code)
                .IsUnicode(false);

            modelBuilder.Entity<address>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<address>()
                .Property(e => e.last_update)
                .IsUnicode(false);
        }*/
    }
}

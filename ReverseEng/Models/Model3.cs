namespace ReverseEng.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model3 : DbContext
    {
        public Model3()
            : base("name=Model3")
        {
        }

        public virtual DbSet<city> cities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<city>()
                .Property(e => e.city1)
                .IsUnicode(false);

            modelBuilder.Entity<city>()
                .Property(e => e.last_update)
                .IsUnicode(false);
        }
    }
}

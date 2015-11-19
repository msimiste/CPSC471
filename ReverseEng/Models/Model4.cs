namespace ReverseEng.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model4 : DbContext
    {
        public Model4()
            : base("name=Model41")
        {
        }

        public virtual DbSet<inventory> inventories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<inventory>()
                .Property(e => e.last_update)
                .IsUnicode(false);
        }
    }
}

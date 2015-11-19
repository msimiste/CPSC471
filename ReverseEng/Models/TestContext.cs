using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ReverseEng.Models
{
    public class TestContext : DbContext
    {
        public TestContext() : base("NewConnection") { }
        public DbSet<member> members { get; set; }
        public DbSet<actor> actors { get; set; }
        public DbSet<address> addresses { get; set; }
        public virtual DbSet<city> cities { get; set; }
        public virtual DbSet<inventory> inventories { get; set; }
    }
}
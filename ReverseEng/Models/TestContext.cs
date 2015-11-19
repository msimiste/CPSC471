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
    }
}
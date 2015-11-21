using CPSC471_TennisClub.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CPSC471_TennisClub
{
    public class TennisDatabaseContext : DbContext
    {

        public TennisDatabaseContext() : base("NewConnection") { }

        public virtual DbSet<member> members { get; set; }
    }
}
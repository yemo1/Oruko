using OrukoData;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OrukoNG.Entities
{
    public class OrukoContext:DbContext
    {
        public DbSet<Tune> Tunes { get; set; }
        public DbSet<ETune> ETunes { get; set; }
    }
}
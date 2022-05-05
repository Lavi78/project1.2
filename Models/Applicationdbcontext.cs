using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace project1._2.Models
{
    public class Applicationdbcontext : DbContext
    {
        public Applicationdbcontext():
             base("Data Source=CHETUIWK222;Initial Catalog=CrudDb;Integrated Security=True;Pooling=False")
        { }
        public DbSet<Item> items { get; set; }
        public DbSet<employee>employees{ get; set; }

    }
}
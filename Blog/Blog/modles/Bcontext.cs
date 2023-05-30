using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.modles
{
    internal class Bcontext : DbContext
    {
        public virtual DbSet<User> users { get; set; }
        public virtual DbSet<Cataloge> cataloge { get; set; }
        public virtual DbSet<News> Newses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-7OFS8L5;Initial Catalog=News;Integrated Security=True;TrustServerCertificate=True");
        }
    }
}

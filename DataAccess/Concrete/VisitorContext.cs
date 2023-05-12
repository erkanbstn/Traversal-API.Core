

using Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete
{
    public class VisitorContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=GEOPC\\SQLEXPRESS;Initial Catalog=TraversalDbApi;Integrated Security=True;");
        }
        public DbSet<Visitor> Visitors { get; set; }
    }
}

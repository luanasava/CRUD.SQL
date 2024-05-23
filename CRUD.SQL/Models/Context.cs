using Microsoft.EntityFrameworkCore;

namespace CRUD.SQL.Models
{
    public class Context : DbContext
    {
        public Context( DbContextOptions<Context> options ):base(options)
        {

        }     
        
        public DbSet<Produto> Produtos { get; set; }
    }
}

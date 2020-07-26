using Domain.Entity;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<T> options) : base(options)
        {
        }
        public DbSet<HeroEntity> Livros { get; set; }
    }
}
}

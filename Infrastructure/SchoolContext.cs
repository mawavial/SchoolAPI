using Domain.Entity;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {

        }

        public DbSet<HeroEntity> Heroes { get; set; }
        public DbSet<StudentEntity> Students { get; set; }
        public DbSet<SchoolEntity> Schools { get; set; }
        public DbSet<ClassEntity> Classes { get; set; }
    }
}

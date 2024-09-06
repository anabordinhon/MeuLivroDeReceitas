using Microsoft.EntityFrameworkCore;
using MyRecipeBook.Domain.Entities;

namespace MyRecipeBook.Infraestructure.DataAccess
{
    public class MyRecipeBookDbContext : DbContext
    {
        public MyRecipeBookDbContext(DbContextOptions options) : base(options) { }

        public DbSet<User> Users { get; set; } //representa uma tabela

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //utilizara as configurações do projeto
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MyRecipeBookDbContext).Assembly);
        }


    }
}

using Microsoft.EntityFrameworkCore;

namespace RecipeApi.Dbinfrastructure
{
    public class RecipeDbContext : DbContext, IUnitOfWork
    {
        public RecipeDbContext(DbContextOptions<RecipeDbContext> options)
            : base(options)
        { }

        public void Commit()
        {
            this.SaveChanges();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new RecipeEntityConfiguration());
        }

    }
}

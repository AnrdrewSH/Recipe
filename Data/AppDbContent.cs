using Microsoft.EntityFrameworkCore;
using Recipe_Api.Data.Entities;

namespace Recipe_Api.Data
{
    public class AppDbContent : DbContext
    {
        public AppDbContent(DbContextOptions<AppDbContent> options) : base (options)
        {

        }

        //public DbSet<Step> Step { get; set; }
        public DbSet<Recipe> Recipe { get; set; }
        public DbSet<Tag> Tag { get; set; }




    }
}

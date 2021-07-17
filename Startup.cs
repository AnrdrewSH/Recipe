using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Recipe_Api.Data;
using Recipe_Api.Data.Interfaces;
using Recipe_Api.Data.Repository;


namespace Recipe_Api
{
    public class Startup
    {

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            const string connectionString = @"Data Source=LAPTOP-0NI53OGU\SQLEXPRESS;Initial Catalog=MySecondDB;Pooling=true;Integrated Security=SSPI";
            services.AddDbContext<AppDbContent>(options => options.UseSqlServer(connectionString));
            services.AddTransient<IRecipeOutputData, RecipeRepository>();
            services.AddTransient<ITag, TagRepository>();

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();

            app.UseStaticFiles();

            //app.UseMvcWithDefaultRoute();
        }
    }
}

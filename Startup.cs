using Microsoft.EntityFrameworkCore;
using Data;
namespace Main
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages().AddRazorRuntimeCompilation();

            var connString = Configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<WeblogContext>(
                options => options.UseSqlServer(connString) 
            );
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
           app.UseDeveloperExceptionPage();

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
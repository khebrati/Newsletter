using Data;
namespace Main
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //TODO: initializing the database (only if there is no data)
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
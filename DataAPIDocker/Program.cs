using DataAPIDocker.Models;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace DataAPIDocker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //note that migrating during startup is for DEMO only
            //in production I'd migrate outside of the app
            //also there's a small chance of conflict if this is hosted
            //in multiple places and migrate is hit at the same moment.
            CreateWebHostBuilder(args).Build().MigrateDatabase<CaptainContext>().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}

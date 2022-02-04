using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagementGrid
{
    //WebAssemblyHostBuilder
    public class Program
    {
        //Microsoft.AspNetCore.Builder.

        public static void Main(string[] args)
        {

            ILoggerFactory loggerFactory = new LoggerFactory();

            ILogger logger = loggerFactory.CreateLogger<Program>();
            logger.LogInformation("This is log message.");

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

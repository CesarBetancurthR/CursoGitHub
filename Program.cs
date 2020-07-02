// Pull request con Cambios
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace WebMartes
{
    public class Program
    {
        //Cambios para GitHub
        public static void Main(string[] args)
        {
            //super idea de And :)
            CreateHostBuilder(args).Build().Run();
        }
        
        //pruebassss fork

        //Cambio Conflictivo
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}

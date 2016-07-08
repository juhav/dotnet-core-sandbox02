using System;
using System.IO;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace ConsoleApplication
{
    public class Startup
    {
        public Startup()
        {
        }

         // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddMvc();

            services.AddLogging();

            // Add our repository type
            // services.AddSingleton<ITodoRepository, TodoRepository>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            
            app.UseMvcWithDefaultRoute();
            // app.Run(context =>
            // {
            //     return context.Response.WriteAsync("Hello!");
            // });

            DefaultFilesOptions options = new DefaultFilesOptions();
            options.DefaultFileNames.Clear();
            options.DefaultFileNames.Add("index.html");
            app.UseDefaultFiles(options);
            app.UseStaticFiles();
            
        }

        public static void Main(string[] args)
        {
            var builder = new Microsoft.Extensions.Configuration.ConfigurationBuilder();

            var config = builder
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var host = new WebHostBuilder()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseConfiguration(config)
                .UseStartup<Startup>()
                .UseKestrel()
                .Build();


            host.Run();
        }      
    }
}
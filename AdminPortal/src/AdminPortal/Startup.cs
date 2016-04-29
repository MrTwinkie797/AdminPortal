using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Extensions.Logging;

namespace AdminPortal
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            var connString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=AdminPortal;Integrated Security=True;Pooling=False";

            services.AddEntityFramework()
                .AddSqlServer()
                .AddDbContext<IdentityDbContext>(options =>
                options.UseSqlServer(connString));

            services.AddIdentity<IdentityUser, IdentityRole>(options =>
            {
                options.Password.RequiredLength = 1;
                options.Password.RequireUppercase = false;
                options.Password.RequireNonLetterOrDigit = false;
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
            })
                .AddEntityFrameworkStores<IdentityDbContext>()
                .AddDefaultTokenProviders();

            services
                .AddEntityFramework()
                .AddSqlServer()
                .AddDbContext<DbContext>(
                options => options.UseSqlServer(connString));

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app,
            ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(minLevel: LogLevel.Verbose);

            app.UseIISPlatformHandler();
            app.UseStaticFiles();
            app.UseMvc();
            app.UseDeveloperExceptionPage();
            app.UseIdentity();
            app.UseMvcWithDefaultRoute();

            app.Run(async (context) =>
            {
                var logger = loggerFactory.CreateLogger("Catchall Endpoint");
                logger.LogInformation("No endpoint found request {path}", context.Request.Path);
                await context.Response.WriteAsync("No endpoint found - try /api/todo.");
            });
        }

        // Entry point for the application.
        public static void Main(string[] args) => WebApplication.Run<Startup>(args);
    }
}

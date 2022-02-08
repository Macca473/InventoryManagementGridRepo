using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryManagementGrid.DBContext;
using System.Diagnostics;
using MySqlConnector;

namespace InventoryManagementGrid
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

            Console.WriteLine("Starting App");


            services.AddRazorPages();

            services.AddMvc();
            services.Add(
                new ServiceDescriptor(typeof(InvGridDbContext), new InvGridDbContext(Configuration.GetConnectionString("InvGridDbContext"))));

            //services.AddTransient<MySqlConnection>(x => new MySqlConnection(Configuration["ConnectionStrings:InvGridDbContext"]));

            //using var connection = new MySqlConnection(yourConnectionString);

            //services.AddDbContext<InvGridDbContext>(options =>
            //options.UseSqlServer(Configuration.GetConnectionString("InvGridDbContext")));
        }



        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            //using (IServiceScope scope = app.ApplicationServices.CreateScope())
            //{
            //    IServiceProvider services = scope.ServiceProvider;

            //    Models.t_table.Init(services);
            //}

            InvGridDbContext invGrid = new InvGridDbContext();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

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

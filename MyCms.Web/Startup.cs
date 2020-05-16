using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyCms.DataLayer;
using MyCms.Services;
using MyCms.Services.Repositories;
using MyCms.Services.Services;

namespace MyCms.Web
{
    public class Startup
    {
        public IConfiguration _Configuration { get; set; }

        public Startup(IConfiguration configuration)
        {
            this._Configuration = configuration;
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddMvc();

            services.AddDbContext<MyCmsDbContext>(options =>
               options.UseSqlServer(_Configuration.GetConnectionString("MyCmsDbContext"))
                );

            services.AddTransient<IPageGroupRepository, PageGroupRepository>();
            services.AddTransient<IPageRepository, PageRepository>();
        
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseRouting();

        
            app.UseEndpoints(endpoints =>
            {
                //Areas Route
                endpoints.MapControllerRoute(
                    name: "Areas",
                    pattern: "{area:exists}/{controller=Homw}/{action=Index}/{id?}");
                    


                //Defult Route
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

               

            });
        }
    }
}

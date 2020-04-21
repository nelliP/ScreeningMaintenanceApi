
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using ScreeningMaintenance.DataAccess.Interfaces;
using ScreeningMaintenance.DataAccess.Repositories;
using ScreeningMaintenanceDataAccess.Context;
using AutoMapper;
using Swashbuckle.AspNetCore.Swagger;
using ScreeningMaintenance.Api.Utilities;
using System;

namespace ScreeningMaintenance.Api
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
            services.AddAutoMapper();
            services.AddSingleton<IMapper, Mapper>();
            services.AddMvc();
            services.AddScoped<IScreeningMaintenanceRepository, ScreeningMaintenanceRepository>();
            var connection = @"Server=(localdb)\mssqllocaldb;Database=ScreeningMaintenanceTest;Trusted_Connection=True;";
            services.AddDbContext<ScreeningMaintenanceContext>(options => options.UseSqlServer(connection));
            services.AddSwaggerGen(c => {
                c.SwaggerDoc("v1", new Info
                {
                    Version = "v1",
                    Title = "Screening Maintenance API",
                    Description = "ASP.NET Core 2.0 Web API specificly for Screening Maintenance Web Application Angular 5.",
                    TermsOfService = "None",
                    Contact = new Contact()
                    {
                        Name = "P C"                        
                    }
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(
                policy =>
            {
                policy.WithOrigins(Configuration.GetValue<string>("Authentication:CorsOrigin"));
                policy.AllowAnyHeader();
                policy.AllowAnyMethod();
                policy.WithExposedHeaders("WWW-Authenticate");
            }
            );
         
            app.UseMvc(
                routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller}/{action=Index}/{id?}");

                routes.MapRoute(
            name: "new",
            template: "{controller}/{action=CreateMaintenance}/{regionDivision}/{screeningType}");
            }
            );
            app.UseSwagger();
            app.UseSwaggerUI(c => {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Screening Maintenance API V1");
            });
        }
    }
}

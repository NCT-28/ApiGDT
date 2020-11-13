using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIGDTVietNam.Data;
using APIGDTVietNam.Models;
using AutoMapper;
using Microsoft.AspNet.OData.Builder;
using Microsoft.AspNet.OData.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OData.Edm;

namespace APIGDTVietNam
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
             var connection = @"Server=TOANNC7\SQLEXPRESS;Database=QLAccountDB ;User ID=ApiGDTVN;Password=admin;";
           
            // services.AddDbContext<CommanderContext>(opt => opt.UseSqlServer
            // (Configuration.GetConnectionString("CommanderConnection")));
            services.AddDbContext<QLAccountContext>(opt => opt.UseSqlServer
            (connection));
            services.AddControllers();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapODataRoute("odata", "odata", GetEdmModel(app.ApplicationServices));
            });
        }
        private static IEdmModel GetEdmModel(IServiceProvider serviceProvider)
        {
            var builder = new ODataConventionModelBuilder(serviceProvider);
            builder.EntitySet<Account>("Account");
            builder.EntitySet<AccountDetails>("AccountDetails");
            return builder.GetEdmModel();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;
using SpeedUpCoreWebApiExample.Contexts;
using SpeedUpCoreWebApiExample.Interfaces;
using SpeedUpCoreWebApiExample.Repositories;
using SpeedUpCoreWebApiExample.Services;

namespace SpeedUpCoreWebApiExample
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
            

            services.AddMvc();

            services.AddDbContext<DefaultContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultDatabase")));

            services.AddScoped<IPricesRepository, PricesRepository>();
            services.AddScoped<IProductsRepository, ProductsRepository>();

            services.AddTransient<IProductsServices, ProductsService>();
            services.AddTransient<IPricesService, PricesService>();                     


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}

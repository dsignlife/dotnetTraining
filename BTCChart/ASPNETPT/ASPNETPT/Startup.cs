﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNETPT.Controllers.Web.Services;
using ASPNETPT.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;


namespace ASPNETPT
{
    public class Startup
    {
        private IHostingEnvironment _env;
        private IConfigurationRoot _config;

        public Startup(IHostingEnvironment env)
        {
            _env = env;
            var builder = new ConfigurationBuilder()
                .SetBasePath(_env.ContentRootPath)
                .AddJsonFile("config.json")
                .AddEnvironmentVariables();
            _config = builder.Build();

        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddSingleton(_config);
            if (_env.IsEnvironment("Development"))
            {
                services.AddScoped<IMailService, DebugMailService>();
            }
                  else
            {
                
            }

            services.AddDbContext<BtcContext>();
            services.AddScoped<IBtcRepo, BtcRepo>();
            services.AddTransient<BtcContextData>();

            services.AddLogging();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory factory) //Add BtcContextData seedData to update to db
        {
            

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                factory.AddDebug(LogLevel.Information);
            }
            else
            {
                factory.AddDebug(LogLevel.Error);
            }

            
            app.UseStaticFiles();
            app.UseMvc(config =>
                {
                    config.MapRoute(
                        name: "Default",
                        template: "{controller}/{action}/{id?}",
                        defaults: new {controller = "App", action = "Index"}
                    );
                }
        );

            //incase seedingData
            //seedData.seedData().Wait();

        }
    }
}

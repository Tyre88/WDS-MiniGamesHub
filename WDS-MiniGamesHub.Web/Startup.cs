using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Reflection;
using MediatR.Pipeline;
using MediatR;
using WDS_MiniGamesHub.Core.Infrastructure;
using FluentValidation.AspNetCore;
using WDS_MiniGamesHub.Core.Infrastructure.AutoMapper;
using WDS_MiniGamesHub.Core.User.Queries;
using AutoMapper;
using WDS_MiniGamesHub.Persistence.Mysql;
using Microsoft.EntityFrameworkCore;

namespace WDS_MiniGamesHub.Web
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
            services.AddAutoMapper(new Assembly[] { typeof(AutoMapperProfile).GetTypeInfo().Assembly });

            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestPreProcessorBehavior<,>));
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestPerformanceBehaviour<,>));
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestValidationBehavior<,>));
            //services.AddMediatR(typeof(GetUserQueryHandler).GetTypeInfo().Assembly);
            services.AddMediatR();

            services.AddSwaggerDocument(config =>
            {
                config.PostProcess = document =>
                {
                    document.Info.Version = "v1";
                    document.Info.Title = "WDS MiniGames API";
                    document.Info.Description = "";
                    document.Info.TermsOfService = "None";
                    document.Info.Contact = new NSwag.SwaggerContact
                    {
                        Name = "Victor Öhrström",
                        Email = string.Empty,
                        Url = "https://gradera.nu"
                    };
                };
            });

            services.AddDbContext<WDSMiniGamesHubDbContext>(options => options.UseMySql("server=127.0.0.1;port=3306;database=142212-wds-minigameshub;uid=142212_gg94104;password=***"));

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1).AddFluentValidation();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();
            app.UseSwaggerUi3();

            app.UseMvc();
        }
    }
}

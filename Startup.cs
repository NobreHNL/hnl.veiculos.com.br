using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using AutoMapper;
using hnl.veiculos.com.br.Mappers;
using hnl.veiculos.com.br.Services;
using hnl.veiculos.com.br.Interfaces.Services;
using hnl.veiculos.com.br.Interfaces.Repositories;
using hnl.veiculos.com.br.Repositories;
using hnl.veiculos.com.br.Data;
using Microsoft.EntityFrameworkCore;
using hnl.veiculos.com.br.Entities;
using System;
using System.Net;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Swashbuckle.AspNetCore.Swagger;

namespace hnl.veiculos.com.br
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
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });


            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);

            services.AddDbContext<DataContext>(x => x.UseSqlite(Configuration.GetConnectionString("DefaultConnection")));

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddCors();
            services.AddTransient<Seed>();
            services.AddScoped<IMarcaService, MarcaService>();
            services.AddScoped<IMarcaRepository, MarcaRepository>();
            services.AddScoped<IModeloService, ModeloService>();
            services.AddScoped<IModeloRepository, ModeloRepository>();

            services.AddSwaggerGen(swagger =>
            {
                swagger.SwaggerDoc("v1", new Info { Title = "HNL Veículos", Version = "v1" });
            });

            // In production, the Angular files will be served from this directory
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp/dist";
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, Seed seeder)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler(builder =>
                {
                    builder.Run(async context =>
                    {
                        context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

                        var error = context.Features.Get<IExceptionHandlerFeature>();
                        if (error != null)
                        {
                            await context.Response.WriteAsync(error.Error.Message);
                        }
                    });
                });
                //app.UseHsts();
            }

            //Create Seed
            seeder.SeedMarcasModelos();

            app.UseSwagger();
            app.UseSwaggerUI(swagger => {
                swagger.SwaggerEndpoint("/swagger/v1/swagger.json", "HNL Veículos");
            });

            app.UseStaticFiles();
            app.UseSpaStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller}/{action=Index}/{id?}");
            });

            app.UseCors(builder =>
                builder.AllowAnyOrigin());

            app.UseSpa(spa =>
            {
                spa.Options.SourcePath = "ClientApp";

                if (env.IsDevelopment())
                {
                    spa.UseAngularCliServer(npmScript: "start");
                }
            });
        }
    }
}

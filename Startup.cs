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
            var mappingConfig = new MapperConfiguration(mc => {
                mc.AddProfile(new MappingProfile());
            });


            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);            
            
            services.AddDbContext<AppDbContext>(options => options.UseInMemoryDatabase("InMemoryDatabase"));
            // services.AddEntityFrameworkSqlServer().AddDbContext<AppDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("BaseCotacoes")));
            
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddCors();

            services.AddScoped<IMarcaService, MarcaService>();
            services.AddScoped<IMarcaRepository, MarcaRepository>();
            services.AddScoped<IModeloService, ModeloService>();
            services.AddScoped<IModeloRepository, ModeloRepository>();

            // In production, the Angular files will be served from this directory
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp/dist";
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

            //var context = app.ApplicationServices.GetService<AppDbContext>();
            //DBInit();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

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
                // To learn more about options for serving an Angular SPA from ASP.NET Core,
                // see https://go.microsoft.com/fwlink/?linkid=864501

                spa.Options.SourcePath = "ClientApp";

                if (env.IsDevelopment())
                {
                    spa.UseAngularCliServer(npmScript: "start");
                }
            });
        }

        private static void DBInit(AppDbContext context){            
            var chevroletId = Guid.NewGuid();
            var fiatId = Guid.NewGuid();
            var auditId = Guid.NewGuid();

            context.Marca.Add(new Marca(chevroletId, "Chevrolet", "https://upload.wikimedia.org/wikipedia/pt/thumb/3/34/Chevrolet_logo.png/250px-Chevrolet_logo.png"));
            context.Marca.Add(new Marca(fiatId, "Fiat", "https://upload.wikimedia.org/wikipedia/en/thumb/9/96/Fiat_Logo.svg/1200px-Fiat_Logo.svg.png"));
            context.Marca.Add(new Marca(auditId, "Audi", "https://upload.wikimedia.org/wikipedia/commons/thumb/7/7f/Audi_logo_detail.svg/200px-Audi_logo_detail.svg.png"));
        
            context.Modelo.Add(new Modelo(Guid.NewGuid(), chevroletId, "Prisma 2020", "Chevrolet", "https://4.bp.blogspot.com/-7cHtB4maTyw/Wv2UOd1yW_I/AAAAAAAAFaA/ShzPpHwM7dsQN_BcWFdb2_v7-zjEiWLfACLcBGAs/s1600/novo-Prisma-2020%2B%25282%2529.jpg"));
            context.Modelo.Add(new Modelo(Guid.NewGuid(), chevroletId, "Onix", "Chevrolet", "https://img1.icarros.com/dbimg/imgmodelo/2/2428_2.png"));
            context.Modelo.Add(new Modelo(Guid.NewGuid(), chevroletId, "Cruze", "Chevrolet", "https://www.rydellchev.com/assets/stock/ColorMatched_01/White/640/cc_2018CHC300005_01_640/cc_2018CHC300005_01_640_G9K.jpg"));
            context.Modelo.Add(new Modelo(Guid.NewGuid(), chevroletId, "Camaro LT in Duluth", "Chevrolet", "https://www.hendrickatlanta.com/assets/stock/colormatched_01/white/640/cc_2018chc020001_01_640/cc_2018chc020001_01_640_g7q.jpg"));

            context.Modelo.Add(new Modelo(Guid.NewGuid(), fiatId, "Toro 2020", "Fiat", "http://samamveiculos.com.br/wp-content/uploads/2016/02/toro-volcano-20.png"));
            context.Modelo.Add(new Modelo(Guid.NewGuid(), fiatId, "Freemont", "Fiat", "http://autosemotos.com/wp-content/uploads/2018/07/FREEMONT.png"));
            context.Modelo.Add(new Modelo(Guid.NewGuid(), fiatId, "Siena", "Fiat", "http://s2.glbimg.com/fekxKOHGimt5Urh7IDV9v6dnvkk=/e.glbimg.com/og/ed/f/original/2014/10/24/fiat_siena_el.png"));
            context.Modelo.Add(new Modelo(Guid.NewGuid(), fiatId, "Argo", "Fiat", "http://www.fiatauguri.com.br/assets/uploads/novos/argoW.png"));

            context.Modelo.Add(new Modelo(Guid.NewGuid(), auditId, "TT", "Audi", "https://content.audi.co.uk/dam/7_days/CAD/External%20Assets/TT/TT_Coupe_S-line/035.png"));
            context.Modelo.Add(new Modelo(Guid.NewGuid(), auditId, "R8", "Audi", "https://ae01.alicdn.com/kf/HTB1WML8PVXXXXX7XXXXq6xXFXXXN/Venda-quente-1-32-para-modelos-audi-r8-liga-cars-modelos-crian-as-toys-atacado-luxuoso.jpg_640x640.jpg"));
            context.Modelo.Add(new Modelo(Guid.NewGuid(), auditId, "A5", "Audi", "https://img0.icarros.com/dbimg/imgmodelo/2/984_9.png"));
            context.Modelo.Add(new Modelo(Guid.NewGuid(), auditId, "A7", "Audi", "http://www.autoline.com.br/images/cms//novo-audi-a7-a-caminho1.jpg"));
        
            context.SaveChanges();
        }
    }
}

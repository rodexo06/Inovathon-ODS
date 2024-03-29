using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using BeeSafeAPI.Model;
using Microsoft.EntityFrameworkCore;
using BeeSafeAPI.Repositories;
using BeeSafeAPI.Repositories.Contracts;

namespace BeeSafeAPI
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
            services.AddControllers();
            services.AddScoped<Perfil>();
            services.AddScoped<IPerfilRepository, PerfilRepository>();
            string conncetionstring = @"Data Source=DESKTOP-J2RA9IJ;Initial Catalog=BeeSafe;Integrated Security=True;Pooling=False";
            /*
 * Session - Configura��o
 */
            services.AddMemoryCache(); //Guardar os dados na mem�ria
            services.AddSession(options => {

            });

            services.AddDbContext<BeeSafeContext>(option => option.UseSqlServer(conncetionstring));
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
                endpoints.MapControllers();
            });
        }
    }
}

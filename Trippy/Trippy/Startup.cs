using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;

namespace Trippy
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            return new DI.ServiceProvider(services).Initialize();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseMvcWithDefaultRoute();
            app.MapWhen(IsClientRoute, UseSpaFallbackRoute);

            app.UseDefaultFiles();
            app.UseStaticFiles();
        }

        private bool IsClientRoute(HttpContext context)
        {
            var requestPath = context.Request.Path.Value;
            return requestPath.StartsWith("/client") && !Path.HasExtension(requestPath);
        }

        private void UseSpaFallbackRoute(IApplicationBuilder app)
        {
            app.UseMvc(routes =>
            {
                routes.MapSpaFallbackRoute("spa-fallback", new { controller = "Home", action = "SpaClient" });
            });
        }
    }
}

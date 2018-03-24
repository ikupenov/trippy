using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;
using System.Threading.Tasks;

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
            //app.Use(WebClientHandler);

            app.UseDefaultFiles();
            app.UseStaticFiles();
        }

        //private async Task WebClientHandler(HttpContext context, Func<Task> next)
        //{
        //    await next();

        //    if (!Path.HasExtension(context.Request.Path.Value) &&
        //        !context.Request.Path.Value.StartsWith("/api/"))
        //    {
        //        context.Request.Path = "/client/index.html";
        //        await next();
        //    }
        //}
    }
}

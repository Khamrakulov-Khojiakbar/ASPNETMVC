using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Stuffmanagement2.Models;

namespace Stuffmanagement2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var services = builder.Services;
            services.AddMvc(options => options.EnableEndpointRouting = false);
            services.AddSingleton<IStaffRepository, MockStaffRepository>();


            var app = builder.Build();


            string? value = builder.Configuration["WeolcomeMessage"] ?? "HelloWorld";
            if(app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            /*app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync(value);
                });
            });*/


            app.UseStaticFiles();
            app.UseFileServer();
            app.UseMvc();
            // app.UseMvcWithDefaultRoute();
            

            
            app.Run();
        }
    }
}

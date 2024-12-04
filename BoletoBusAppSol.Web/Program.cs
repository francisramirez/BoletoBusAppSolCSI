using BoletoBusAppSol.Data.Context;
using BoletoBusAppSol.Data.Interfaces;
using BoletoBusAppSol.Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BoletoBusAppSol.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<BoletoContext>(options => 
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("BoletoConnString"));
              
            });

            
            // el registro de las dependencias de los repositorios..
            builder.Services.AddTransient<IBusRepository, BusRepository>();

            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}

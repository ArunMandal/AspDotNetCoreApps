﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AspDotNetCoreMVCProject.Data;
namespace AspDotNetCoreMVCProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<AspDotNetCoreMVCProjectContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("AspDotNetCoreMVCProjectContext") ?? throw new InvalidOperationException("Connection string 'AspDotNetCoreMVCProjectContext' not found.")));

            // Add services to the container.
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
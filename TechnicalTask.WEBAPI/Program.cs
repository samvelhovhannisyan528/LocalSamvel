using Microsoft.EntityFrameworkCore;
using TechnicalTask.Entities.Context;
using TechnicalTask.Entities.Entities;
using TechnicalTask.Entities.Interfaces;
using TechnicalTask.Entities.Repositories;
using TechnicalTask.Services;

namespace TechnicalTask.WEBAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var configuration = builder.Configuration;
            configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            builder.Services.AddDbContext<TechnicalTaskDbContext>(options =>
                    options.UseSqlite(configuration.GetConnectionString("TechnicalTaskDbConnectionString")));

            // Add services to the container.
            builder.Services.AddTransient<IBaseRepository<Employee>, BaseRepository<Employee>>();
            builder.Services.AddTransient<IBaseRepository<Project>, BaseRepository<Project>>();
            builder.Services.AddTransient<IBaseRepository<Position>, BaseRepository<Position>>();
            builder.Services.AddTransient<IBaseRepository<Service>, BaseRepository<Service>>();
            builder.Services.AddServiceLayer();

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}

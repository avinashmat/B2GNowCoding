using B2GNowCoding.Core.Extensions;
using B2GNowCoding.Extensions;
using Microsoft.EntityFrameworkCore;
namespace B2GNowCoding
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<Db.B2GNowCodingDbContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("B2GNowCodingConnectionString")));
            builder.Services.AddMediatorDependecies();
            builder.Services.AddRepositoryDependencies();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}

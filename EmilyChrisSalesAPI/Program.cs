using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using EmilyChrisSalesAPI.Data;
namespace EmilyChrisSalesAPI;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddDbContext<EmilyChrisSalesAPIContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("EmilyChrisSalesAPIContext") ?? throw new InvalidOperationException("Connection string 'EmilyChrisSalesAPIContext' not found.")));

        // Add services to the container.

        builder.Services.AddControllers();



        var app = builder.Build();

        builder.Services.AddCors();

        // Configure the HTTP request pipeline.
        app.UseCors(x=> x.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());

        app.UseAuthorization();


        app.MapControllers();

        app.Run();
    }
}

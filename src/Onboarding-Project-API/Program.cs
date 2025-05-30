using Microsoft.EntityFrameworkCore;

namespace Onboarding_Project_API;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddAuthorization();

        // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
        builder.Services.AddOpenApi();
        builder.Services.AddControllers();
        
        var dbHost = "localhost";
        var dbName = "onboarding";
        var dbPassword = "password";

        var connectionString = $"server={dbHost};port=3306;database={dbName};user=root;password={dbPassword}";
        builder.Services.AddDbContext<ScoreDbContext>(o => o.UseMySQL(connectionString));
        
        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.MapOpenApi();
        }

        app.UseHttpsRedirection();

        app.UseRouting();
        app.UseAuthorization();
        
        app.UseEndpoints(endpoints => endpoints.MapControllers());
        app.Run();
    }
}
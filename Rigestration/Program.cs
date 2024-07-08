using Domain1.Entities;
using Interface1.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Rigestration;

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

        builder.Services.AddDbContext<AppIdentityDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

        builder.Services.AddIdentity<AppUser, IdentityRole>(Options =>
        {
            //Options.Password.RequireDigit = false;
            //Options.Password.RequireLowercase = false;
            //Options.Password.RequireUppercase = false;
            //Options.Password.RequireNonAlphanumeric = false;
            //Options.Password.RequiredLength = 6;
        }).AddEntityFrameworkStores<AppIdentityDbContext>();
        var app = builder.Build();
        using var scope = app.Services.CreateScope();
        var services = scope.ServiceProvider;
        var context = services.GetRequiredService<AppIdentityDbContext>();

        var userManager = services.GetRequiredService<UserManager<AppUser>>();

        AppIdentityDbContextSeed.SeedAsync(userManager);

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

using Carpooling_App.Data;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        new MySqlServerVersion(new Version(8, 0, 25))
    )
);

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});


var app = builder.Build();

app.UseHttpsRedirection();

app.UseCors("AllowAllOrigins");

app.MapGet("/", async (AppDbContext db) =>
    await db.Ride
            .Include(r => r.Customer) 
            .ToListAsync());


app.MapGet("/search", async (AppDbContext db, string? StartLocation,
    string? EndLocation, string? Date, int? SeatsAvailable) =>
{
    var query = db.Ride
        .Include(r => r.Customer) 
        .AsQueryable();

    if (!string.IsNullOrEmpty(StartLocation))
    {
        query = query.Where(r => r.StartLocation == StartLocation);
    }

    if (!string.IsNullOrEmpty(EndLocation))
    {
        query = query.Where(r => r.EndLocation == EndLocation);
    }

    if (!string.IsNullOrEmpty(Date))
    {
        DateOnly.TryParse(Date, out var parsedDate);
        query = query.Where(r => r.Date == parsedDate);
    }

    if (SeatsAvailable.HasValue)
    {
        query = query.Where(r => r.SeatsAvailable >= SeatsAvailable.Value);
    }

    return await query.ToListAsync();
});



app.Run();

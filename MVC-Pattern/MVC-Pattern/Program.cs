using Microsoft.EntityFrameworkCore;
using MVC_Pattern.Data;
using MVC_Pattern.Interfaces;
using MVC_Pattern.Repository;
using RunGroopWebApp.Data;

var builder = WebApplication.CreateBuilder(args);

// Log the connection string to verify it's being loaded correctly
Console.WriteLine("Connection String: " + builder.Configuration.GetConnectionString("DefaultConnection"));

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IRaceRepository, RaceRepository>();
builder.Services.AddScoped<IClubRepository, ClubRepository>();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

var app = builder.Build();
if(args.Length == 1 && args[0].ToLower() == "seeddata")
{
    Seed.SeedData(app);
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

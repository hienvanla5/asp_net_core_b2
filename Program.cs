using Buoi2.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<MvcMovieContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("MvcMovieContext")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

// Demo Conventional Routing: /conventional, /conventional/details/2, /conventional/about
app.MapControllerRoute(
    name: "conventional-demo",
    pattern: "conventional/{action=Index}/{id?}",
    defaults: new { controller = "Routing" });

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();

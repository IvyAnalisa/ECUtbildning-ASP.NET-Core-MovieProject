using IvyBio.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("IvyBioContextConnection"); ;
/*
builder.Services.AddDbContext<IvyBioContext>(options =>
    options.UseSqlServer(connectionString)); ;*/
//Identity
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<IvyBioContext>(); ;

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<IvyBioContext>
    (options => options.UseSqlServer(
        builder.Configuration.GetConnectionString("Default")));
var app = builder.Build();

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
app.UseAuthentication(); ;

app.UseAuthorization();

//search movie Route set up
app.MapControllerRoute(
    name: "movie",
    pattern: "search",
    defaults: new { controller = "SearchMoviesController", action = "Index" });

//set up Rout for Admin
app.MapAreaControllerRoute(
    name: "admin",
    areaName: "Admin",
    pattern: "Admin/{controller=Home}/{action=Index}/{id?}");

// set up Route for homepage Index
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();
app.Run();

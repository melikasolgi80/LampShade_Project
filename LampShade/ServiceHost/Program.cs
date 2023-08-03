using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using ShopManagement.Application.Contracts.ProductCategory;
using ShopManagement.Application;
using ShopManagement.Configuration;
using ShopManagement.Domain;
using ShopManagement.Infrastructure.EFCore;
using ShopManagement.Infrastructure.EFCore.Repository;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//builder.Services.AddDbContext<shopContext>(options => {
//var config = builder.Configuration;
// var connectionString = config.GetConnectionString("LampShadeDb");
//   options.UseSqlServer(connectionString);
//});


var connectionString =builder.Configuration.GetConnectionString("LampShadeDb");
ShopManagementBootstraper.Configure(builder.Services,connectionString);




builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();
app.MapDefaultControllerRoute();

app.Run();

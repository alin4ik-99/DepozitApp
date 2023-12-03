using DepozitApp.BLL.Interfaces;
using DepozitApp.BLL.Services;
using DepozitApp.DAL.EF;
using DepozitApp.DAL.Interfaces;
using DepozitApp.DAL.Repositories;
using DepozitApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IDepozitCalculateService, DepozitCalculateService>();

builder.Services.AddScoped<IGetDataByDateServise, GetDataByDateServise>();

builder.Services.AddScoped<IGetCurrenciesReportServise, GetCurrenciesReportServise>();

builder.Services.AddScoped<IMounthlyDepozitReportRepository, MounthlyDepozitReportRepository>();

builder.Services.AddScoped<IGetRequestService, GetRequestService>();

builder.Services.AddScoped<DataContext>();

builder.Services.AddHttpClient();

builder.Services.AddScoped<IBaseRepository<MounthlyDepozitReport>, MounthlyDepozitReportRepository>();

builder.Services.AddScoped<IBaseRepository<CurrenciesReport>, CurrenciesReportRepository>();

builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

// Add services to the container.
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();

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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

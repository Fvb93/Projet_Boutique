using Microsoft.EntityFrameworkCore;
using Projet_Boutique.BLL.Services;
using Projet_Boutique.BLL.Services.Interfaces;
using Projet_Boutique.DAL.DataBase;
using Projet_Boutique.DAL.Repositories;
using Projet_Boutique.DAL.Repositories.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Add DB Context
builder.Services.AddDbContext<BoutiqueContext>(b => b.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

// Add repository FROM DAL
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();

// Add servies From BLL
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();

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

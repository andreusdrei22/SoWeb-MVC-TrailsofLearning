using Microsoft.EntityFrameworkCore;
using Web_MVC_TrailsofLearning.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<Contexto>
    (Options => Options.UseSqlServer("workstation id=pwdbtcc.mssql.somee.com;packet size=4096;user id=drei_SQLLogin_1;pwd=jidb81ybdv;data source=pwdbtcc.mssql.somee.com;persist security info=False;initial catalog=pwdbtcc;TrustServerCertificate=True"));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Alunoes}/{action=Index}/{id?}");

app.Run();

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

using T3_PILCO_JOSE.Datos;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options =>
                                                   options.UseSqlServer(
                                                   builder.Configuration.GetConnectionString("DefaultConnection"))
                                                   );

builder.Services.AddDefaultIdentity<IdentityUser>()
.AddEntityFrameworkStores<ApplicationDbContext>();

;



builder.Services.AddControllersWithViews();

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
app.UseAuthorization();
app.MapRazorPages();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

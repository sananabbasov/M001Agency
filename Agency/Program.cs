using Agency.Data;
using Agency.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddScoped<DataSeeding>();


var connectingString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDbContext>
    (options => options.UseSqlServer(connectingString));

builder.Services.AddDefaultIdentity<M001User>().AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<AppDbContext>();



builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/dashboard/auth/login"; // Login 
    options.AccessDeniedPath = "/dashboard/auth/login"; // Claim

});



var app = builder.Build();
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
});

app.MapControllerRoute(
    name: "default",
    pattern:"{controller=Home}/{action=Index}/{id?}"
);




app.Run();

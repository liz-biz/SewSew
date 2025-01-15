using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SewSew.Areas.Identity.Data;
using SewSew.Areas.Identity.Roles;
using SewSew.Data;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("SewSewDBContextConnection") ?? throw new InvalidOperationException("Connection string 'SewSewDBContextConnection' not found.");

//services
var serviceProvider = builder.Services.BuildServiceProvider();
await RoleInitializer.InitializeAsync(serviceProvider);

builder.Services.AddDbContext<SewSewDBContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddDefaultIdentity<SewSewUser>(options => options.SignIn.RequireConfirmedAccount = false).AddEntityFrameworkStores<SewSewDBContext>();

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

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
app.MapRazorPages();

app.Run();

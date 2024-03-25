using BookStore.Data;
using BookStore.Data.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

string connectionString = builder.Configuration.GetConnectionString("SqlConnection")
	?? throw new InvalidOperationException("Connection string 'SqlConnection' not found.");

builder.Services.AddDbContext<BookStoreDbContext>(options =>
	options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();


builder.Services.AddDefaultIdentity<ApplicationUser>(options =>
{
	options.SignIn.RequireConfirmedAccount =
		builder.Configuration.GetValue<bool>("Identity:SignIn:RequireConfirmedAccount");
	options.Password.RequireLowercase =
		builder.Configuration.GetValue<bool>("Identity:Password:RequireLowercase");
	options.Password.RequireUppercase =
		builder.Configuration.GetValue<bool>("Identity:Password:RequireUppercase");
	options.Password.RequireNonAlphanumeric =
		builder.Configuration.GetValue<bool>("Identity:Password:RequireNonAlphanumeric");
	options.Password.RequiredLength =
		builder.Configuration.GetValue<int>("Identity:Password:RequiredLength");

})
 .AddEntityFrameworkStores<BookStoreDbContext>();


builder.Services.AddControllersWithViews();

WebApplication app = builder.Build();



if (app.Environment.IsDevelopment())
{
	app.UseMigrationsEndPoint();
	app.UseDeveloperExceptionPage();
}
else
{
	app.UseExceptionHandler("/Home/Error");
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(ep =>
{
	ep.MapControllerRoute(
	name: "Areas",
	pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

	ep.MapDefaultControllerRoute();
	ep.MapRazorPages();

});

app.Run();

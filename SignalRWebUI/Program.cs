using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using SignalRBLL.DependencyResolvers;
var builder = WebApplication.CreateBuilder(args);

var requireAuthorizePolicy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();

// Add services to the container.
builder.Services.AddControllersWithViews(opt =>
{
	opt.Filters.Add(new AuthorizeFilter(requireAuthorizePolicy));
});
builder.Services.AddHttpClient();
builder.Services.AddIdentityService();
builder.Services.AddDbContextService();
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(x =>
{
	x.LoginPath = "/Login/Index/";
});
builder.Services.ConfigureApplicationCookie(opts =>
{
	opts.LoginPath = "/Login/Index/";
});
var app = builder.Build();
app.UseStatusCodePages(async statusCode =>
{
	if (statusCode.HttpContext.Response.StatusCode == 404) { }
	{
		statusCode.HttpContext.Response.Redirect("/Error/NotFound404/");
	}
});


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
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Default}/{action=Index}/{id?}");

app.Run();

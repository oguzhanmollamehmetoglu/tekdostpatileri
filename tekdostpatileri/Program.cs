using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
.AddCookie(opt =>
{
    opt.Cookie.HttpOnly = true; //document.cookie kapatýr
    opt.Cookie.Name = "TekDostPatileri";
    opt.Cookie.SameSite = Microsoft.AspNetCore.Http.SameSiteMode.Strict; //cookie kullanýmýný diger sayfalara kapatýr
    opt.Cookie.SecurePolicy = Microsoft.AspNetCore.Http.CookieSecurePolicy.SameAsRequest; //http ve https ile çalýþ

    opt.ExpireTimeSpan = TimeSpan.FromDays(60);

    opt.LoginPath = new Microsoft.AspNetCore.Http.PathString("/Admin/Home/Index");

});

builder.Services.AddSession(option =>
{
    option.IdleTimeout = TimeSpan.FromDays(7);
});

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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

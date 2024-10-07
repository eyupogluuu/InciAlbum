using FluentValidation;
using InciAlbum.BusinessLayer.Abstract;
using InciAlbum.BusinessLayer.Concrete;
using InciAlbum.DataAccessLayer.Abstract;
using InciAlbum.DataAccessLayer.Concrete.EntityFramework;
using InciAlbum.DataAccessLayer.Contexts;
using InciAlbum.EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<InciAlbumContext>();

builder.Services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<InciAlbumContext>();

builder.Services.AddScoped<ImyServiceService, myServiceManager>();
builder.Services.AddScoped<ImyServiceDal, EFmyServiceDal>();

builder.Services.AddScoped<IStuffService, StuffManager>();
builder.Services.AddScoped<IStuffDal, EFStuffDal>();

builder.Services.AddScoped<INoticeService, NoticeManager>();
builder.Services.AddScoped<INoticeDal, EFNoticeDal>();

builder.Services.AddScoped<IImageService, ImageManager>();
builder.Services.AddScoped<IImageDal, EFImageDal>();

builder.Services.AddScoped<ImyAdressService, myAdressManager>();
builder.Services.AddScoped<ImyAdressDal, EFmyAdressDal>();

builder.Services.AddScoped<IContactService, ContactManager>();
builder.Services.AddScoped<IContactDal, EFContactDal>();

builder.Services.AddScoped<IProductService, ProductManager>();
builder.Services.AddScoped<IProductDal, EFProductDal>();

builder.Services.AddScoped<IAboutService, AboutManager>();
builder.Services.AddScoped<IAboutDal, EFAboutDal>();

builder.Services.AddScoped<IAdminService, AdminManager>();
builder.Services.AddScoped<IAdminDal, EFAdminDal>();

builder.Services.AddMvc(config =>

{
    var policy = new AuthorizationPolicyBuilder()
    .RequireAuthenticatedUser()
    .Build();
    config.Filters.Add(new AuthorizeFilter(policy));
});

builder.Services.AddAuthentication(
    CookieAuthenticationDefaults.AuthenticationScheme)
   .AddCookie(x =>
    {
   x.LoginPath = "/Login/Index/";

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
app.UseAuthentication();

app.UseRouting();

app.UseAuthorization();
app.MapDefaultControllerRoute();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=ShowCase}/{action=Index}/{id?}");

app.Run();

using FluentValidation;
using InciAlbum.BusinessLayer.Abstract;
using InciAlbum.BusinessLayer.Concrete;
using InciAlbum.DataAccessLayer.Abstract;
using InciAlbum.DataAccessLayer.Concrete.EntityFramework;
using InciAlbum.DataAccessLayer.Contexts;
using InciAlbum.EntityLayer.Concrete;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<InciAlbumContext>();

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
app.MapDefaultControllerRoute();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

﻿using CaKoi.Respositories;
using CaKoi.Respositories.Entities;
using CaKoi.Respositories.Interface;
using CaKoi.Services;
using CaKoi.Services.Interface;
using Microsoft.EntityFrameworkCore;
using WebAppCaKoi.Controllers;
using static WebAppCaKoi.Controllers.AdminController;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
   
        builder.Services.AddHttpContextAccessor();

        builder.Services.AddSession(options =>
        {
            options.IdleTimeout = TimeSpan.FromMinutes(30);
            options.Cookie.HttpOnly = true;
            options.Cookie.IsEssential = true;
        });
        // dùng cookie để giải quyết chuyện đăng nhập
        builder.Services.AddAuthentication(options =>
        {
            options.DefaultScheme = "CookieAuth"; // Chọn Default Scheme là CookieAuth
        })
 .AddCookie("CookieAuth", options =>
 {
     options.LoginPath = "/Home/Login"; // Đường dẫn đăng nhập cho khách hàng
     options.LogoutPath = "/Home/Logout"; // Đường dẫn đăng xuất cho khách hàng
 })
 .AddCookie("EmployeeCookie", options =>
 {
     options.LoginPath = "/NhanVien/LoginNhanVien"; // Đường dẫn đăng nhập cho nhân viên
     options.LogoutPath = "/NhanVien/LogoutNhanVien"; // Đường dẫn đăng xuất cho nhân viên
 });
        //phân quyền
        builder.Services.AddAuthorization(options =>
        {
            // Policy cho khách hàng (kiểm tra claim "IdKh")
            options.AddPolicy("CustomerPolicy", policy =>
                policy.RequireClaim("IdKh"));

            // Policy cho nhân viên (kiểm tra claim "Idnv")
            options.AddPolicy("EmployeePolicy", policy =>
                policy.RequireClaim("Idnv"));
        });

        // Add services to the container.
        builder.Services.AddControllersWithViews();
       
        //DI
        builder.Services.AddDbContext<CaKoiContext>(options =>
        {
            options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectedDb"));
        });
        //DI Respositories
        builder.Services.AddScoped<IKhachHangRespository, KhachHangRespository>();
        //DI Services
        builder.Services.AddScoped<IKhachHangService, KhachHangService>();

        //DI Cá Koi
        builder.Services.AddScoped<ICaCoiRespository, CaCoiRespository>();
        builder.Services.AddScoped<ICaCoiService, CaCoiService>();
        //DI Đơn Hàng
        builder.Services.AddScoped<IDonHangService, DonHangService>();
        builder.Services.AddScoped<IDonHangRespository, DonHangRespository>();
        //DI ShopCart
        builder.Services.AddScoped<ICartRespository, CartRespository>();
        builder.Services.AddScoped<ICartService, CartService>();
        //DI NhanVien
        builder.Services.AddScoped<INhanVienRespository, NhanVienRespository>();
        builder.Services.AddScoped<INhanVienService, NhanVienService>();
        //phân quyền


        var app = builder.Build();

       
        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            app.UseHsts();
        }
        app.UseStaticFiles();

        app.UseRouting();

        // sư dụng session
        app.UseSession();
        app.UseAuthentication();
        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
              name: "areas",
              pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

            app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");
        });


        app.Run();
    }
}

using CaKoi.Respositories;
using CaKoi.Respositories.Entities;
using CaKoi.Respositories.Interface;
using CaKoi.Services;
using CaKoi.Services.Interface;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        //thêm session
        builder.Services.AddSession(options =>
        {
            options.IdleTimeout = TimeSpan.FromMinutes(30);
            options.Cookie.HttpOnly = true;
            options.Cookie.IsEssential = true;
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

        //DI
        builder.Services.AddScoped<ICaCoiRespository, CaCoiRespository>();
        builder.Services.AddScoped<ICaCoiService, CaCoiService>();
        var app = builder.Build();


        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
        }
        app.UseStaticFiles();

        
        app.UseRouting();
        app.UseSession();
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

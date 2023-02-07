using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using ShopProjectAsp_PhamVanLinh.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<Context>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultContext")
    )
);
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options => {                    // Đăng ký dịch vụ Session
    options.Cookie.Name = "phamvanlinh";             // Đặt tên Session - tên này sử dụng ở Browser (Cookie)
    options.IdleTimeout = new TimeSpan(0, 30, 0);    // Thời gian tồn tại của Session
    options.Cookie.IsEssential = true;
    options.Cookie.HttpOnly = true;
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseSession();

app.UseStaticFiles();
app.UseRouting();
app.UseDeveloperExceptionPage();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Index}/{action=Index}/{id?}");

app.Run();

using fronttoback.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<AppDbContext>(options =>
       options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));
builder.Services.AddControllersWithViews();
var app = builder.Build();




app.UseStaticFiles();


app.MapControllerRoute(
    name: "default",
    pattern: "{Controller=Home}/{action=index}"

    );

app.Run();

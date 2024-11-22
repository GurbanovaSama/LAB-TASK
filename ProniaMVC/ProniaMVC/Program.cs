using Microsoft.EntityFrameworkCore;
using ProniaMVC.Contexts;
using ProniaMVC.Models;
using System;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder .Services.AddDbContext<ProniaDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("MsSql")));
var app = builder.Build();

app.UseStaticFiles();

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
    );

app.Run();



using (var context = new ProniaDbContext())
{
    var slider = new SliderItem
    {
        Title = "New Plant",
        ShortDesc = "Pronia, With 100% Natural, Organic & Plant Shop.",
        DiscountPercent = 65,
        ImagePath = "1-2-524x617.png"
    };
    context.SliderItems.Add(slider);
    context.SaveChanges();
}


using Microsoft.EntityFrameworkCore;
using WeaponShop.Infrastructure.Data;

var builder = WebApplication.CreateBuilder(args);

// === Service Configuration ===

// Add MVC support (Controllers + Views)
builder.Services.AddControllersWithViews();

// Register EF Core with SQL Server
builder.Services.AddDbContext<AppDbContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
    
// Add other services here (e.g., repositories, UoW, services, etc.)

var app = builder.Build();

// === Middleware Pipeline ===

// Use exception handling (custom error page in production)
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts(); // Add HTTP Strict Transport Security -> browser will refuse to talk over HTTP but HTTPS
}

app.UseHttpsRedirection(); // Redirect HTTP to HTTPS
app.UseStaticFiles();      // Serve files from wwwroot
app.UseRouting();          // Enable routing
app.UseAuthorization();    // Enable [Authorize] (even if unused for now)

// === Routing ===

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

// Run the app
app.Run();
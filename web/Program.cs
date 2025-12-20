using Microsoft.EntityFrameworkCore;
using TransactsWeb.Data;
using Microsoft.AspNetCore.Authentication.Cookies;

try
{
Console.WriteLine("[STARTUP] Creating web application builder...");
var builder = WebApplication.CreateBuilder(args);

// Configure to listen on port 5000
builder.WebHost.ConfigureKestrel(options => {
    options.ListenAnyIP(5000);
});

Console.WriteLine("[STARTUP] Configuring logging...");
builder.Logging.ClearProviders();
builder.Logging.AddConsole();
builder.Logging.SetMinimumLevel(LogLevel.Debug);

// Add services to the container.
Console.WriteLine("[STARTUP] Adding MVC services...");
builder.Services.AddControllersWithViews();

// Add Entity Framework
Console.WriteLine("[STARTUP] Configuring Entity Framework with SQLite...");
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
Console.WriteLine($"[STARTUP] Connection string: {connectionString}");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite(connectionString));

// Add Authentication
Console.WriteLine("[STARTUP] Configuring authentication...");
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = "/Account/Login";
        options.LogoutPath = "/Account/Logout";
        options.AccessDeniedPath = "/Account/AccessDenied";
    });

Console.WriteLine("[STARTUP] Building application...");
var app = builder.Build();
Console.WriteLine("[STARTUP] Application built successfully.");

// Auto-migrate database on startup
Console.WriteLine($"[STARTUP] Environment: {app.Environment.EnvironmentName}");
Console.WriteLine("[DATABASE] Starting database initialization...");
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    try
    {
        Console.WriteLine("[DATABASE] Ensuring database is created...");
        context.Database.EnsureCreated();
        Console.WriteLine("[DATABASE] Database ready.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"[DATABASE] Warning: {ex.Message}");
        Console.WriteLine("[DATABASE] Continuing without database...");
    }
}

// Configure the HTTP request pipeline.
Console.WriteLine("[STARTUP] Configuring HTTP pipeline...");
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
Console.WriteLine("[STARTUP] Skipping HTTPS redirection");
Console.WriteLine("[STARTUP] Adding middleware: Static files");
app.UseStaticFiles();

Console.WriteLine("[STARTUP] Adding middleware: Routing");
app.UseRouting();

// Health check endpoint
app.MapGet("/health", () => {
    Console.WriteLine("[HEALTH] Health check requested");
    return Results.Ok(new { status = "healthy", timestamp = DateTime.UtcNow });
});

Console.WriteLine("[STARTUP] Adding middleware: Authentication");
app.UseAuthentication();
Console.WriteLine("[STARTUP] Adding middleware: Authorization");
app.UseAuthorization();

Console.WriteLine("[STARTUP] Mapping controller routes");
try
{
    app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
    Console.WriteLine("[STARTUP] Routes mapped successfully");
}
catch (Exception ex)
{
    Console.WriteLine($"[STARTUP] Error mapping routes: {ex.Message}");
    throw;
}

Console.WriteLine("[STARTUP] Starting web server...");
Console.WriteLine("[STARTUP] Application is ready to accept requests.");
app.Run();
}
catch (Exception ex)
{
    Console.WriteLine($"[FATAL ERROR] Application failed to start: {ex.Message}");
    Console.WriteLine($"[FATAL ERROR] Exception type: {ex.GetType().Name}");
    Console.WriteLine($"[FATAL ERROR] Stack trace: {ex.StackTrace}");
    if (ex.InnerException != null)
    {
        Console.WriteLine($"[FATAL ERROR] Inner exception: {ex.InnerException.Message}");
    }
    throw;
}
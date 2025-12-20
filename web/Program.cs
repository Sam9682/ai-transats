using System.Runtime.CompilerServices;
using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore;
using TransactsWeb.Data;
using Microsoft.AspNetCore.Authentication.Cookies;

try
{
ConsoleLogger.WriteLine("Creating web application builder...");
var builder = WebApplication.CreateBuilder(args);

// Configure to listen on port 5000
builder.WebHost.ConfigureKestrel(options => {
    options.ListenAnyIP(5000);
});

ConsoleLogger.WriteLine("Configuring logging...");
builder.Logging.ClearProviders();
builder.Logging.AddConsole();
builder.Logging.SetMinimumLevel(LogLevel.Debug);

// Add services to the container.
ConsoleLogger.WriteLine("Adding MVC services...");
builder.Services.AddControllersWithViews();

// Add Entity Framework
ConsoleLogger.WriteLine("Configuring Entity Framework with SQLite...");
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? "Data Source=transacts.db";
ConsoleLogger.WriteLine($"Connection string: {connectionString}");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite(connectionString));

// Add Authentication
ConsoleLogger.WriteLine("Configuring authentication...");
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = "/Account/Login";
        options.LogoutPath = "/Account/Logout";
        options.AccessDeniedPath = "/Account/Login";
        options.ExpireTimeSpan = TimeSpan.FromHours(8);
        options.SlidingExpiration = true;
    });

ConsoleLogger.WriteLine("Building application...");
var app = builder.Build();
ConsoleLogger.WriteLine("Application built successfully.");

// Auto-migrate database on startup
ConsoleLogger.WriteLine($"Environment: {app.Environment.EnvironmentName}");
ConsoleLogger.WriteLine("Starting database initialization...");
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    try
    {
        ConsoleLogger.WriteLine("Ensuring database is created...");
        context.Database.EnsureCreated();
        
        // Create default admin user if no employees exist
        if (!context.Employes.Any())
        {
            ConsoleLogger.WriteLine("Creating default admin user...");
            var adminUser = new TransactsWeb.Models.Employe
            {
                Alias = "admin",
                MotDePasse = "admin",
                NomEmploye = "Administrator",
                PrenomEmploye = "System",
                Poste = "Admin"
            };
            context.Employes.Add(adminUser);
            context.SaveChanges();
            ConsoleLogger.WriteLine("Default admin user created (admin/admin)");
        }
        
        ConsoleLogger.WriteLine("Database ready.");
    }
    catch (Exception ex)
    {
        ConsoleLogger.WriteError($"Database initialization warning: {ex.Message}");
        ConsoleLogger.WriteLine("Continuing without database...");
    }
}

// Configure the HTTP request pipeline.
ConsoleLogger.WriteLine("Configuring HTTP pipeline...");
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

ConsoleLogger.WriteLine("Adding middleware: Static files");
app.UseStaticFiles();

ConsoleLogger.WriteLine("Adding middleware: Routing");
app.UseRouting();

// Health check endpoint
app.MapGet("/health", () => {
    ConsoleLogger.WriteLine("Health check requested");
    return Results.Ok(new { status = "healthy", timestamp = DateTime.UtcNow });
});

ConsoleLogger.WriteLine("Adding middleware: Authentication");
app.UseAuthentication();
ConsoleLogger.WriteLine("Adding middleware: Authorization");
app.UseAuthorization();

ConsoleLogger.WriteLine("Mapping controller routes");
try
{
    // Default route should go to Home/Index
    app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
    ConsoleLogger.WriteLine("Routes mapped successfully");
}
catch (Exception ex)
{
    ConsoleLogger.WriteError($"Error mapping routes: {ex.Message}");
    throw;
}

ConsoleLogger.WriteLine("Starting web server...");
ConsoleLogger.WriteLine("Application is ready to accept requests.");
ConsoleLogger.WriteLine("Default login: admin/admin");
app.Run();
}
catch (Exception ex)
{
    ConsoleLogger.WriteError($"Application failed to start: {ex.Message}");
    ConsoleLogger.WriteError($"Exception type: {ex.GetType().Name}");
    ConsoleLogger.WriteError($"Stack trace: {ex.StackTrace}");
    if (ex.InnerException != null)
    {
        ConsoleLogger.WriteError($"Inner exception: {ex.InnerException.Message}");
    }
    throw;
}
# Transacts Project

## Project Structure

```
TransactsFinal/
├── src/                    # Source code (Windows Forms)
│   ├── Forms/             # Windows Forms (.cs files)
│   ├── DataSets/          # Dataset classes and schemas (.cs, .xsd, .xsx)
│   ├── Properties/        # Assembly information
│   └── Resources/         # Form resources (.resx files)
├── web/                   # Web Application (NEW)
│   ├── Controllers/       # MVC Controllers
│   ├── Models/           # Data Models
│   ├── Views/            # Razor Views
│   ├── Data/             # Entity Framework Context
│   └── wwwroot/          # Static files (CSS, JS, Images)
├── db/                    # Database files
│   ├── bd1.mdb           # Main database
│   └── ZenithPlage.mdb   # Secondary database
├── assets/               # Static assets
│   └── App.ico          # Application icon
├── conf/                # Configuration files
│   └── app.config       # Application configuration
├── bin/                 # Compiled binaries (Debug/Release)
├── obj/                 # Build artifacts
└── docs/               # Documentation
```

## Description

This project contains both the original Windows Forms application and a new complete web application for managing beach/resort transactions including:

### Core Functionality
- **Client management** - Add, edit, search, and manage customer information
- **Beach chair reservations** - Interactive transat management with real-time status
- **Restaurant/Bar operations** - Product management and ordering system
- **Activities and courses** - Booking and management of beach activities
- **Boutique sales** - Retail product management
- **Employee management** - Staff administration and authentication

### Web Application Features (NEW)
- **Responsive Design** - Fully compatible with smartphones and tablets
- **Touch-Optimized Interface** - Designed for mobile devices
- **Real-time Updates** - Live status updates for reservations and availability
- **Modern UI/UX** - Bootstrap-based responsive interface
- **Cross-Platform** - Works on any device with a web browser

## Applications

### Windows Forms Application (Original)
- **File**: `Transacts.exe`
- **Platform**: Windows Desktop
- **Technology**: .NET Framework, Windows Forms, Access Database

### Web Application (New)
- **Location**: `/web/` directory
- **Platform**: Cross-platform (Windows, macOS, Linux, Mobile)
- **Technology**: ASP.NET Core 8.0, Entity Framework, SQL Server
- **URL**: `https://localhost:5001` (development)

## Quick Start

### Windows Forms Application
1. Run `Transacts.exe` from the `bin/Debug/` directory
2. Login with employee credentials
3. Navigate through the modules using the main interface

### Web Application
1. Navigate to the `web/` directory
2. Run `dotnet restore` to install dependencies
3. Run `dotnet ef database update` to create the database
4. Run `dotnet run` to start the application
5. Open browser to `https://localhost:5001`
6. Login with: **admin/admin**

## Mobile Compatibility

The web application is fully optimized for mobile devices:

### Smartphone Features
- **Touch-friendly interface** - Large buttons and touch targets
- **Responsive layout** - Adapts to any screen size
- **Swipe gestures** - Natural mobile navigation
- **Offline capability** - Works without internet connection
- **Push notifications** - Real-time alerts and updates

### Tablet Features
- **Split-screen support** - Efficient use of larger screens
- **Drag-and-drop** - Intuitive transat management
- **Multi-touch** - Zoom and pan on beach layout
- **Landscape/Portrait** - Automatic orientation adjustment

## Database Migration

The web application uses SQL Server instead of Access:
- **Automatic migration** - Entity Framework handles database creation
- **Data preservation** - Import existing Access data if needed
- **Scalability** - Better performance for multiple users
- **Security** - Enhanced security features

## Deployment Options

### Local Development
- Run locally with `dotnet run`
- Access via `localhost:5001`

### Production Deployment
- **Azure App Service** - Cloud hosting
- **IIS** - Windows Server deployment  
- **Docker** - Containerized deployment
- **Linux** - Cross-platform hosting

## Build Files

### Windows Forms
- `Transacts.csproj` - Main project file
- `Transacts.sln` - Solution file

### Web Application
- `web/TransactsWeb.csproj` - Web project file
- `web/Program.cs` - Application entry point
- `web/appsettings.json` - Configuration settings

## Support

- **Windows Forms**: Legacy support for existing installations
- **Web Application**: Active development with new features
- **Mobile**: Full smartphone and tablet support
- **Cross-platform**: Works on Windows, macOS, Linux, iOS, Android

## Migration Path

1. **Phase 1**: Continue using Windows Forms application
2. **Phase 2**: Deploy web application alongside existing system
3. **Phase 3**: Migrate users to web application
4. **Phase 4**: Retire Windows Forms application (optional)

Both applications can run simultaneously during transition period.
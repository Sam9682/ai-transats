@echo off
echo Starting Transacts Web Application...
echo.

REM Check if Docker is running
docker version >nul 2>&1
if %errorlevel% neq 0 (
    echo ERROR: Docker is not running!
    echo Please start Docker Desktop and try again.
    echo.
    pause
    exit /b 1
)

echo Docker is running, building and starting containers...
docker-compose up -d --build

if %errorlevel% equ 0 (
    echo.
    echo ✓ Application started successfully!
    echo.
    echo Web App: http://localhost:5000
    echo Database: localhost:1433
    echo.
    echo Login: admin/admin
    echo.
    echo Press any key to view logs...
    pause >nul
    docker-compose logs -f
) else (
    echo.
    echo ✗ Failed to start application
    echo Check the error messages above
    echo.
    pause
)
@echo off
echo Starting Transacts Web Application...
docker-compose up -d --build
echo.
echo Application starting...
echo Web App: http://localhost:8080
echo Database: localhost:1433
echo.
echo Login: admin/admin
echo.
pause
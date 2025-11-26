@echo off
echo Checking Docker Desktop status...

REM Check if Docker Desktop is running
docker version >nul 2>&1
if %errorlevel% equ 0 (
    echo Docker Desktop is already running.
    goto :run_app
)

echo Docker Desktop is not running. Starting it...

REM Try to start Docker Desktop
start "" "C:\Program Files\Docker\Docker\Docker Desktop.exe"

echo Waiting for Docker Desktop to start...
:wait_loop
timeout /t 5 /nobreak >nul
docker version >nul 2>&1
if %errorlevel% neq 0 (
    echo Still waiting for Docker...
    goto :wait_loop
)

echo Docker Desktop is now running!

:run_app
echo.
echo Starting Transacts Web Application...
call run-docker.bat
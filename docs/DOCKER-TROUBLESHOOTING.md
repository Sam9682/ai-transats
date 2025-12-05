# Docker Troubleshooting Guide

## Common Issues and Solutions

### 1. "Docker is not running" Error

**Problem**: `unable to get image 'ai-transats-transacts-web': error during connect`

**Solutions**:
1. **Start Docker Desktop manually**:
   - Open Docker Desktop from Start menu
   - Wait for it to fully start (green icon in system tray)

2. **Use the automated script**:
   ```cmd
   .\start-docker.bat
   ```

3. **Check Docker installation**:
   ```cmd
   docker --version
   ```

### 2. Port Already in Use

**Problem**: `Port 8080 is already allocated`

**Solution**:
```cmd
docker-compose down
netstat -ano | findstr :8080
taskkill /PID <PID_NUMBER> /F
```

### 3. Build Failures

**Problem**: Docker build fails

**Solutions**:
1. **Clean Docker cache**:
   ```cmd
   docker system prune -a
   ```

2. **Rebuild from scratch**:
   ```cmd
   docker-compose down --volumes
   docker-compose up --build --force-recreate
   ```

### 4. Database Connection Issues

**Problem**: Cannot connect to SQL Server

**Solutions**:
1. **Wait for SQL Server to start** (takes 30-60 seconds)
2. **Check container logs**:
   ```cmd
   docker-compose logs sqlserver
   ```

### 5. Memory Issues

**Problem**: Docker runs out of memory

**Solution**:
- Increase Docker Desktop memory limit in Settings > Resources > Advanced

## Quick Commands

```cmd
# Check Docker status
docker version

# View running containers
docker ps

# View all containers
docker ps -a

# View logs
docker-compose logs

# Stop all containers
docker-compose down

# Restart everything
docker-compose restart

# Clean everything
docker-compose down --volumes --remove-orphans
docker system prune -a
```

## Manual Steps

If automated scripts fail:

1. **Start Docker Desktop**
2. **Open Command Prompt as Administrator**
3. **Navigate to project directory**:
   ```cmd
   cd C:\Users\lepet\workspace\ai-transats
   ```
4. **Run Docker Compose**:
   ```cmd
   docker-compose up -d --build
   ```
5. **Access application**: http://localhost:8080
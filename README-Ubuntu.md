# Ubuntu Installation Guide

## Prerequisites

```bash
# Install Docker
sudo apt update
sudo apt install docker.io docker-compose
sudo systemctl start docker
sudo systemctl enable docker
sudo usermod -aG docker $USER
```

## Quick Start

```bash
# Make script executable
chmod +x run-docker.sh

# Launch application
./run-docker.sh
```

## Manual Commands

```bash
# Start containers
docker-compose up -d --build

# View logs
docker-compose logs -f

# Stop containers
docker-compose down

# Access application
firefox http://localhost:8080
```

## Login
- Username: admin
- Password: admin
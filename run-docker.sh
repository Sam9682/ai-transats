#!/bin/bash
echo "Starting Transacts Web Application..."
docker-compose up -d --build
echo
echo "Application starting..."
echo "Web App: http://localhost:5000"
echo "Database: localhost:1433"
echo
echo "Login: admin/password"
echo
read -p "Press Enter to continue..."
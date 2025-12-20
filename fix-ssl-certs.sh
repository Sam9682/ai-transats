#!/bin/bash
# Fix SSL certificate directories issue

set -e

log_info() {
    echo -e "\033[0;32m[INFO]\033[0m $1"
}

log_error() {
    echo -e "\033[0;31m[ERROR]\033[0m $1"
}

# Create ssl directory if it doesn't exist
mkdir -p ssl

# Remove any directories that should be files
if [[ -d "ssl/fullchain.pem" ]]; then
    log_info "Removing directory ssl/fullchain.pem..."
    rm -rf ssl/fullchain.pem
fi

if [[ -d "ssl/privkey.pem" ]]; then
    log_info "Removing directory ssl/privkey.pem..."
    rm -rf ssl/privkey.pem
fi

# Check for existing certificates and copy them properly
if [[ -f "$HOME/.ssh/STAR_swautomorph_com.crt" && -f "$HOME/.ssh/privateKey_STAR_swautomorph_com.key" ]]; then
    log_info "Copying certificates from ~/.ssh/..."
    cp "$HOME/.ssh/STAR_swautomorph_com.crt" ssl/fullchain.pem
    cp "$HOME/.ssh/privateKey_STAR_swautomorph_com.key" ssl/privkey.pem
    
    # Set proper permissions
    chmod 644 ssl/fullchain.pem
    chmod 600 ssl/privkey.pem
    
    log_info "Certificates copied successfully ✅"
elif [[ -f "ssl/STAR_swautomorph_com.crt" && -f "ssl/privateKey_STAR_swautomorph_com.key" ]]; then
    log_info "Using existing certificates from ssl/ directory..."
    cp ssl/STAR_swautomorph_com.crt ssl/fullchain.pem
    cp ssl/privateKey_STAR_swautomorph_com.key ssl/privkey.pem
    
    # Set proper permissions
    chmod 644 ssl/fullchain.pem
    chmod 600 ssl/privkey.pem
    
    log_info "Local certificates copied successfully ✅"
else
    log_error "No SSL certificates found!"
    log_error "Please ensure certificates exist in one of these locations:"
    log_error "  - $HOME/.ssh/STAR_swautomorph_com.crt and $HOME/.ssh/privateKey_STAR_swautomorph_com.key"
    log_error "  - ssl/STAR_swautomorph_com.crt and ssl/privateKey_STAR_swautomorph_com.key"
    exit 1
fi

# Verify the certificates are files, not directories
if [[ -f "ssl/fullchain.pem" && -f "ssl/privkey.pem" ]]; then
    log_info "SSL certificates are properly configured as files ✅"
    ls -la ssl/fullchain.pem ssl/privkey.pem
else
    log_error "SSL certificates are not properly configured"
    exit 1
fi
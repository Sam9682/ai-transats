// Global JavaScript functions for the application

// Show loading spinner
function showLoading() {
    const loadingHtml = '<div class="spinner"></div>';
    document.body.insertAdjacentHTML('beforeend', '<div id="loading-overlay" style="position: fixed; top: 0; left: 0; width: 100%; height: 100%; background: rgba(255,255,255,0.8); z-index: 9999; display: flex; align-items: center; justify-content: center;">' + loadingHtml + '</div>');
}

// Hide loading spinner
function hideLoading() {
    const overlay = document.getElementById('loading-overlay');
    if (overlay) {
        overlay.remove();
    }
}

// Format currency
function formatCurrency(amount) {
    return new Intl.NumberFormat('fr-FR', {
        style: 'currency',
        currency: 'EUR'
    }).format(amount);
}

// Format date
function formatDate(date) {
    return new Intl.DateTimeFormat('fr-FR', {
        year: 'numeric',
        month: '2-digit',
        day: '2-digit',
        hour: '2-digit',
        minute: '2-digit'
    }).format(new Date(date));
}

// Confirm dialog with custom styling
function confirmAction(message, callback) {
    if (confirm(message)) {
        callback();
    }
}

// Toast notification system
function showToast(message, type = 'info') {
    const toastHtml = `
        <div class="toast align-items-center text-white bg-${type} border-0" role="alert" aria-live="assertive" aria-atomic="true">
            <div class="d-flex">
                <div class="toast-body">
                    ${message}
                </div>
                <button type="button" class="btn-close btn-close-white me-2 m-auto" data-bs-dismiss="toast"></button>
            </div>
        </div>
    `;
    
    let toastContainer = document.getElementById('toast-container');
    if (!toastContainer) {
        toastContainer = document.createElement('div');
        toastContainer.id = 'toast-container';
        toastContainer.className = 'toast-container position-fixed bottom-0 end-0 p-3';
        document.body.appendChild(toastContainer);
    }
    
    toastContainer.insertAdjacentHTML('beforeend', toastHtml);
    const toastElement = toastContainer.lastElementChild;
    const toast = new bootstrap.Toast(toastElement);
    toast.show();
    
    // Remove toast element after it's hidden
    toastElement.addEventListener('hidden.bs.toast', () => {
        toastElement.remove();
    });
}

// Handle AJAX errors
function handleAjaxError(xhr, status, error) {
    console.error('AJAX Error:', error);
    showToast('Une erreur est survenue. Veuillez réessayer.', 'danger');
    hideLoading();
}

// Setup CSRF token for AJAX requests
function setupCSRF() {
    const token = document.querySelector('input[name="__RequestVerificationToken"]');
    if (token) {
        $.ajaxSetup({
            beforeSend: function(xhr) {
                xhr.setRequestHeader('RequestVerificationToken', token.value);
            }
        });
    }
}

// Initialize application
document.addEventListener('DOMContentLoaded', function() {
    setupCSRF();
    
    // Setup global AJAX error handling
    $(document).ajaxError(handleAjaxError);
    
    // Setup loading indicators for AJAX requests
    $(document).ajaxStart(showLoading);
    $(document).ajaxStop(hideLoading);
    
    // Initialize tooltips
    const tooltipTriggerList = [].slice.call(document.querySelectorAll('[data-bs-toggle="tooltip"]'));
    tooltipTriggerList.map(function (tooltipTriggerEl) {
        return new bootstrap.Tooltip(tooltipTriggerEl);
    });
    
    // Auto-hide alerts after 5 seconds
    setTimeout(function() {
        const alerts = document.querySelectorAll('.alert:not(.alert-permanent)');
        alerts.forEach(function(alert) {
            const bsAlert = new bootstrap.Alert(alert);
            bsAlert.close();
        });
    }, 5000);
});

// Utility functions for mobile detection
function isMobile() {
    return window.innerWidth <= 768;
}

function isTouch() {
    return 'ontouchstart' in window || navigator.maxTouchPoints > 0;
}

// Responsive table helper
function makeTablesResponsive() {
    const tables = document.querySelectorAll('table:not(.table-responsive table)');
    tables.forEach(function(table) {
        if (!table.closest('.table-responsive')) {
            const wrapper = document.createElement('div');
            wrapper.className = 'table-responsive';
            table.parentNode.insertBefore(wrapper, table);
            wrapper.appendChild(table);
        }
    });
}

// Call on page load and resize
window.addEventListener('load', makeTablesResponsive);
window.addEventListener('resize', makeTablesResponsive);
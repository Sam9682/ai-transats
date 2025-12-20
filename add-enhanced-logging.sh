#!/bin/bash
# Script to add enhanced Console.WriteLine with timestamps and source file information

# Function to add ConsoleLogger calls to C# files
add_enhanced_logging() {
    local file="$1"
    
    # Skip if file doesn't exist or is not a .cs file
    if [[ ! -f "$file" || ! "$file" =~ \.cs$ ]]; then
        return
    fi
    
    echo "Processing: $file"
    
    # Create backup
    cp "$file" "$file.backup"
    
    # Add using statement if not present
    if ! grep -q "using System.Runtime.CompilerServices;" "$file"; then
        sed -i '1i using System.Runtime.CompilerServices;' "$file"
    fi
    
    # Replace Console.WriteLine with ConsoleLogger.WriteLine
    sed -i 's/Console\.WriteLine(/ConsoleLogger.WriteLine(/g' "$file"
    
    # Replace Console.Write with ConsoleLogger.WriteLine  
    sed -i 's/Console\.Write(/ConsoleLogger.WriteLine(/g' "$file"
    
    # Add logging to method entries (simplified pattern)
    sed -i '/^\s*public\s\+.*\s\+\w\+\s*(/a\\t\t\tConsoleLogger.WriteLine("Method started");' "$file"
    sed -i '/^\s*private\s\+.*\s\+\w\+\s*(/a\\t\t\tConsoleLogger.WriteLine("Method started");' "$file"
    
    # Add error logging to catch blocks
    sed -i '/catch\s*(\s*Exception\s\+\w\+\s*)/a\\t\t\t\tConsoleLogger.WriteError($"Exception caught: {ex.Message}");' "$file"
    
    echo "Enhanced logging added to: $file"
}

# Process all C# files in the Forms directory
find /home/ubuntu/ai-transats/src/Forms -name "*.cs" -type f | while read -r file; do
    add_enhanced_logging "$file"
done

echo "Enhanced logging has been added to all C# files in the Forms directory."
echo "Original files have been backed up with .backup extension."
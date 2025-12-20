using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;

namespace Transacts
{
    /// <summary>
    /// Utility class for enhanced console logging with timestamps and source file information
    /// </summary>
    public static class ConsoleLogger
    {
        /// <summary>
        /// Writes a timestamped message to the console with source file information
        /// </summary>
        /// <param name="message">The message to write</param>
        /// <param name="sourceFilePath">Automatically filled with the source file path</param>
        /// <param name="memberName">Automatically filled with the calling method name</param>
        /// <param name="lineNumber">Automatically filled with the line number</param>
        public static void WriteLine(string message, 
            [CallerFilePath] string sourceFilePath = "", 
            [CallerMemberName] string memberName = "", 
            [CallerLineNumber] int lineNumber = 0)
        {
            string fileName = Path.GetFileName(sourceFilePath);
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            
            Console.WriteLine($"[{timestamp}] [{fileName}:{lineNumber}] [{memberName}] {message}");
        }

        /// <summary>
        /// Writes a timestamped message to the console with source file information (overload for object)
        /// </summary>
        /// <param name="obj">The object to write</param>
        /// <param name="sourceFilePath">Automatically filled with the source file path</param>
        /// <param name="memberName">Automatically filled with the calling method name</param>
        /// <param name="lineNumber">Automatically filled with the line number</param>
        public static void WriteLine(object obj, 
            [CallerFilePath] string sourceFilePath = "", 
            [CallerMemberName] string memberName = "", 
            [CallerLineNumber] int lineNumber = 0)
        {
            WriteLine(obj?.ToString() ?? "null", sourceFilePath, memberName, lineNumber);
        }

        /// <summary>
        /// Writes a timestamped error message to the console with source file information
        /// </summary>
        /// <param name="message">The error message to write</param>
        /// <param name="sourceFilePath">Automatically filled with the source file path</param>
        /// <param name="memberName">Automatically filled with the calling method name</param>
        /// <param name="lineNumber">Automatically filled with the line number</param>
        public static void WriteError(string message, 
            [CallerFilePath] string sourceFilePath = "", 
            [CallerMemberName] string memberName = "", 
            [CallerLineNumber] int lineNumber = 0)
        {
            string fileName = Path.GetFileName(sourceFilePath);
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            
            Console.WriteLine($"[{timestamp}] [ERROR] [{fileName}:{lineNumber}] [{memberName}] {message}");
        }

        /// <summary>
        /// Writes a timestamped warning message to the console with source file information
        /// </summary>
        /// <param name="message">The warning message to write</param>
        /// <param name="sourceFilePath">Automatically filled with the source file path</param>
        /// <param name="memberName">Automatically filled with the calling method name</param>
        /// <param name="lineNumber">Automatically filled with the line number</param>
        public static void WriteWarning(string message, 
            [CallerFilePath] string sourceFilePath = "", 
            [CallerMemberName] string memberName = "", 
            [CallerLineNumber] int lineNumber = 0)
        {
            string fileName = Path.GetFileName(sourceFilePath);
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            
            Console.WriteLine($"[{timestamp}] [WARNING] [{fileName}:{lineNumber}] [{memberName}] {message}");
        }

        /// <summary>
        /// Writes a timestamped debug message to the console with source file information
        /// </summary>
        /// <param name="message">The debug message to write</param>
        /// <param name="sourceFilePath">Automatically filled with the source file path</param>
        /// <param name="memberName">Automatically filled with the calling method name</param>
        /// <param name="lineNumber">Automatically filled with the line number</param>
        [Conditional("DEBUG")]
        public static void WriteDebug(string message, 
            [CallerFilePath] string sourceFilePath = "", 
            [CallerMemberName] string memberName = "", 
            [CallerLineNumber] int lineNumber = 0)
        {
            string fileName = Path.GetFileName(sourceFilePath);
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            
            Console.WriteLine($"[{timestamp}] [DEBUG] [{fileName}:{lineNumber}] [{memberName}] {message}");
        }
    }
}
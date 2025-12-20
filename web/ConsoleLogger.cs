using System;

namespace TransactsWeb
{
    public static class ConsoleLogger
    {
        public static void WriteLine(string message)
        {
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            Console.WriteLine($"[{timestamp}] {message}");
        }

        public static void WriteLine(object obj)
        {
            WriteLine(obj?.ToString() ?? "null");
        }

        public static void WriteError(string message)
        {
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            Console.WriteLine($"[{timestamp}] [ERROR] {message}");
        }

        public static void WriteWarning(string message)
        {
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            Console.WriteLine($"[{timestamp}] [WARNING] {message}");
        }

        public static void WriteDebug(string message)
        {
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            Console.WriteLine($"[{timestamp}] [DEBUG] {message}");
        }
    }
}
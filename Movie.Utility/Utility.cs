using System;
using System.IO;

namespace Movie.Utilities
{
    public class Utility
    {
       public static string GetSqlScript(string filePath)
        {
            if (File.Exists(filePath)) 
               return File.ReadAllText(filePath,System.Text.Encoding.UTF8);
            else
               return string.Empty;
        }

        public static string GetExecutingDirectory()
        {
            return AppDomain.CurrentDomain.BaseDirectory;
        }
    }
}

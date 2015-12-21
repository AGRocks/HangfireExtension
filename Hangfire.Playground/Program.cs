using Hangfire.SQLite;
using System;

namespace Hangfire.Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            var storage = new SQLiteStorage(@"Data Source=c:\mydb.db;Version=3;");
            using (new BackgroundJobServer())
            {
                Console.WriteLine("Hangfire Server started. Press ENTER to exit...");
                Console.ReadLine();
            }
        }
    }
}

using Microsoft.Extensions.Configuration;
using System;
using System.Configuration;

namespace configuration1
{
    class Program
    {
        static void Main(string[] args)
        {
            var buillder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            var defaultConnection = Configuration.GetConnectionString("DefaultConnection");
            
            Console.WriteLine("Hello World!");
        }
    }
}

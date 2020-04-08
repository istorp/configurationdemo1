using Microsoft.Extensions.Configuration;
using System;

namespace configuration1
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            var defaultConnection = builder.GetConnectionString("DefaultConnection");
            var apiKey = builder.GetSection("MySettings")["ApiKey"];

            Console.WriteLine($"Hello World!{defaultConnection}");
        }
    }
}

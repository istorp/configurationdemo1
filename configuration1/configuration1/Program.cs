using Microsoft.Extensions.Configuration;
using System;

namespace configuration1
{
    class Program
    {
        static void Main(string[] args)
        {
            var enviromentName = Environment.GetEnvironmentVariable("ConfigEnv");
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddJsonFile($"appsettings.{enviromentName}.json",optional:true)
                .Build();

            var defaultConnection = builder.GetConnectionString("DefaultConnection");
            var apiKey = builder.GetSection("MySettings")["ApiKey"];

            Console.WriteLine($"Hello World!{defaultConnection}");
        }
    }
}

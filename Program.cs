using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Npgsql.efcore.pg.issue1576repro.Data;

namespace Npgsql.efcore.pg.issue1576repro
{

    class Program
    {
        public static IConfiguration Configuration { get; } = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .AddEnvironmentVariables("ASPNETCORE_")
            .Build();
        static void Main(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseNpgsql(Configuration.GetConnectionString("AppDbContext"));
            var context = new AppDbContext(optionsBuilder.Options);
            context.Database.Migrate();
        }
    }
}

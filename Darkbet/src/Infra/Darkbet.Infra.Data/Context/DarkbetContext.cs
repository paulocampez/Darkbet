using Darkbet.Domain.Models;
using Darkbet.Infra.Data.Mappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Darkbet.Infra.Data.Context
{
    public class DarkbetContext : DbContext
    {
        private readonly IHostingEnvironment _env;

        public DarkbetContext(IHostingEnvironment env)
        {
            _env = env;
        }

        public DbSet<WheelOfFortune> wheelOfFortunes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new WheelOfFortuneMap());

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // get the configuration from the app settings
            var config = new ConfigurationBuilder()
                .SetBasePath(_env.ContentRootPath)
                .AddJsonFile("appsettings.json")
                .Build();

            // definir db
            optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
        }
    }
}

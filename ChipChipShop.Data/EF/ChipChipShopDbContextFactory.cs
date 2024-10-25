using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChipChipShopSolution.Data.EF;

namespace ChipChipShop.Data.EF
{
    public class ChipChipShopDbContextFactory : IDesignTimeDbContextFactory<ChipChipShopDbContext>
    {
        public ChipChipShopDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("ChipChipShopDb");

            var optionsBuilder = new DbContextOptionsBuilder<ChipChipShopDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new ChipChipShopDbContext(optionsBuilder.Options);
        }
    }
}
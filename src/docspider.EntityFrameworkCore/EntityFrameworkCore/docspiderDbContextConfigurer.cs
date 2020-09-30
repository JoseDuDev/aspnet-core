using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace docspider.EntityFrameworkCore
{
    public static class docspiderDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<docspiderDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<docspiderDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}

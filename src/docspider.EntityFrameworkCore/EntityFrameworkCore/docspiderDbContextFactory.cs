using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using docspider.Configuration;
using docspider.Web;

namespace docspider.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class docspiderDbContextFactory : IDesignTimeDbContextFactory<docspiderDbContext>
    {
        public docspiderDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<docspiderDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            docspiderDbContextConfigurer.Configure(builder, configuration.GetConnectionString(docspiderConsts.ConnectionStringName));

            return new docspiderDbContext(builder.Options);
        }
    }
}

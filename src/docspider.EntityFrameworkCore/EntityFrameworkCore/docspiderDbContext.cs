using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using docspider.Authorization.Roles;
using docspider.Authorization.Users;
using docspider.MultiTenancy;
using docspider.Pessoas;
using docspider.Contatos;
using docspider.EntityFrameworkCore.Configurations.Contatos;
using docspider.EntityFrameworkCore.Configurations.Pessoas;

namespace docspider.EntityFrameworkCore
{
    public class docspiderDbContext : AbpZeroDbContext<Tenant, Role, User, docspiderDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Contato> Contatos { get; set; }

        public docspiderDbContext(DbContextOptions<docspiderDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.ApplyConfiguration(new ContatoConfiguration());
            //modelBuilder.ApplyConfiguration(new PessoaConfiguration());

            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        }
    }
}

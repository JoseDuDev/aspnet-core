using docspider.Pessoas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace docspider.EntityFrameworkCore.Configurations.Pessoas
{
    public class PessoaConfiguration : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder
                .ToTable("Pessoa");

            builder
                .HasKey(p => p.Id);

            builder
                .Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(p => p.Sobrenome)
                .IsRequired()
                .HasMaxLength(150);

            builder
                .Property(p => p.DataNascimento)
                .HasColumnName("Nascimento");

            builder
                .HasMany(p => p.Contatos)
                .WithOne();

            builder
                .Property(p => p.CreatorUserId)
                .HasColumnName("CriadoPor");
            builder
                .Property(p => p.CreationTime)
                .HasColumnName("CriadoEm")
                .HasDefaultValueSql("GETDATE()")
                .IsRequired();

            builder
                .Property(p => p.DeleterUserId)
                .HasColumnName("ExcluidoPor");
            builder
                .Property(p => p.DeletionTime)
                .HasColumnName("ExcluidoEm");
            builder
                .Property(p => p.IsDeleted)
                .HasColumnName("Excluido")
                .IsRequired();

            builder
                .Property(p => p.IsActive)
                .HasColumnName("Ativo")
                .IsRequired();
        }
    }
}

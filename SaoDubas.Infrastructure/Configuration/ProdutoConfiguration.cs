using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SaoDubas.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SaoDubas.Infrastructure.Configuration
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder
                .ToTable("Produto_");

            builder
                .Property(p => p.ProdutoId)
                .HasColumnName("Id_Produto");

            builder
                .Property(p => p.Preco)
                .HasColumnName("Vl_Preco");

            builder
                .Property(p => p.Nome)
                .HasColumnName("Nm_Nome");

            builder
                .Property(p => p.Descricao)
                .HasColumnName("Ds_Descricao");
        }
    }
}

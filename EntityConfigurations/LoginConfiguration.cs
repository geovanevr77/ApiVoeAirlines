using VoeAirlines.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VoeAirlines.EntityConfigurations;

public class LoginConfiguration : IEntityTypeConfiguration<Login>
{
    public void Configure(EntityTypeBuilder<Login> builder)
    {
        //Definindo a tabela

        builder.ToTable("Logins");
        
        //único, imútavel e universal
        //chave primária
        builder.HasKey(l =>l.Id);

        //definir usuário
        //Encadeamento de métodos
        builder.Property(l =>l.Usuario)
        .IsRequired()
        .HasMaxLength(40);

        //definir senha
        //Encadeamento de métodos
        builder.Property(l =>l.Senha)
        .IsRequired()
        .HasMaxLength(12);
        
        //definir date de criação
        builder.Property(l =>l.DataCriacao)
        .IsRequired();


    }
}
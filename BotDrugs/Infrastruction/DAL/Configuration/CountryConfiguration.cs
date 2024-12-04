using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastruction.DAL.Configuration;

public class CountryConfiguration : IEntityTypeConfiguration<Country>
{
    public void Configure(EntityTypeBuilder<Country> builder)
    {
        builder.ToTable(nameof(Country));
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).IsRequired().HasMaxLength(100).HasAnnotation($"{builder.Navigation(country => country.Name)}", nameof(Country.Name));
        builder.Property(x => x.Code).IsRequired().HasAnnotation($"{builder.Navigation(country => country.Code)}", nameof(Country.Code));
    }
}
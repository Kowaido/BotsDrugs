using System.Xml;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Infrastruction.DAL.Configuration;

public class DrugConfiguration : IEntityTypeConfiguration<Drug>
{
    public void Configure(EntityTypeBuilder<Drug> Builder)
    {
        Builder.ToTable(nameof(Drug));
        Builder.HasKey(x => x.Id);
        Builder.Property(x => x.Name)
            .IsRequired().HasMaxLength(150).HasAnnotation($"{Builder.Navigation(drug => drug.Name)}", true);
        Builder.Property(x => x.Manufacturer)
            .IsRequired().HasMaxLength(100).HasAnnotation($"{Builder.Navigation(drug => drug.Manufacturer)}", true);
        Builder.Property(x => x.CountryCodeId)
            .IsRequired().HasAnnotation($"{Builder.Navigation(drug => drug.CountryCodeId)}", true);
    }
}
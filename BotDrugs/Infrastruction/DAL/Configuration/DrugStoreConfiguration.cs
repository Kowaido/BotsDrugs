using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastruction.DAL.Configuration;

public class DrugStoreConfiguration : IEntityTypeConfiguration<DrugStore>
{
    public void Configure(EntityTypeBuilder<DrugStore> builder)
    {
        builder.ToTable(nameof(DrugStoreConfiguration));
        builder.HasKey(x => x.Id);
        builder.Property(x => x.DrugNetwork).IsRequired().HasMaxLength(100)
            .HasAnnotation("Сеть аптек", builder.Property(x => x.DrugNetwork));
        builder.Property(x => x.Number).IsRequired().HasPrecision(0).HasAnnotation("Номер аптеки", builder.Property(x => x.Number));
        builder.Property(x => x.Address.Street).IsRequired().HasMaxLength(50).HasAnnotation("Адрес улицы", builder.Property(x => x.Address.Street));
        builder.Property(x => x.Address.House).IsRequired().HasMaxLength(50).HasAnnotation("Адрес дома", builder.Property(x => x.Address.House));
        builder.Property(x => x.Address.Country).IsRequired().HasAnnotation("Адрес страны", builder.Property(x => x.Address.Country));
        builder.Property(x => x.Address.City).IsRequired().HasAnnotation("Адрес города", builder.Property(x => x.Address.City));
        builder.Property(x => x.PhoneNumber).IsRequired().HasMaxLength(15).HasAnnotation("Номер телефона", builder.Property(x => x.PhoneNumber));
    }
}
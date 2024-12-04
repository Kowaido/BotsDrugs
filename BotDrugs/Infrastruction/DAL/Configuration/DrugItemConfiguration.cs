using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastruction.DAL.Configuration;

public class DrugItemConfiguration : IEntityTypeConfiguration<DrugItem>
{
    public void Configure(EntityTypeBuilder<DrugItem> builder)
    {
        builder.ToTable(nameof(DrugItem));
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Cost).IsRequired().HasPrecision(2, 10).HasAnnotation("Стоимость", builder.Property(x => x.Cost));
        builder.Property(x => x.Count).IsRequired().HasAnnotation("Количество", builder.Property(x => x.Count));
        builder.Property(x => x.DrugId).IsRequired().HasAnnotation("Идентификатор лекарства", builder.Property(x => x.DrugId));
        builder.Property(x => x.DrugStoreId).IsRequired().HasAnnotation("Идентификатор аптеки", builder.Property(x => x.DrugStoreId));
    }
}
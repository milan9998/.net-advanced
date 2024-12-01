using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Demo.Infrastructure.Domain.Company;

public class CompanyConfiguration : IEntityTypeConfiguration<Demo.Domain.Entities.Company>
{
    public void Configure(EntityTypeBuilder<Demo.Domain.Entities.Company> builder)
    {
        builder.ToTable("Companies");
        builder.Property(x => x.Id).ValueGeneratedNever();

     /*   builder.Property<Guid>("ProductId");
        builder.HasIndex("ProductId");
        builder.HasMany(x => x.Products).WithOne(x => x.Company);*/
    }
}
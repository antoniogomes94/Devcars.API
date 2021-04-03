using DevCars.API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevCars.API.Persistence.Configurations
{
    public class CarDbConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder
               .HasKey(c => c.Id);

            builder
                .Property(c => c.Brand)
                // .IsRequired()
                // .HasColumnName("Marca")
                .HasColumnType("VARCHAR(100)")
                .HasDefaultValue("PADRÃO")
                .HasMaxLength(100);

            builder
                .Property(c => c.ProductionDate)
                .HasDefaultValueSql("getdate()");

             /*Como definir o nome da tabela no banco de dados, se não configuar ele mantem o nome da classe.
            builder.ToTable("TB_CAR");*/
        }
    }
}

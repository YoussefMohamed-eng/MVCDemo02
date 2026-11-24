using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVCDemo02.Entities;

namespace MVCDemo02.Configurations
{
    public class TrainerConfigurations : GymUserConfigurations<Trainer> , IEntityTypeConfiguration<Trainer>
    {
        public new void Configure (EntityTypeBuilder<Trainer> builder )
        {
            builder.Property(x => x.CreatedAt).HasDefaultValueSql("GETDATE()");
            base.Configure(builder);
        }
    }
}

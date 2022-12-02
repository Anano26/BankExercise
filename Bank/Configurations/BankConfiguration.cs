using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankExercise.Classes;

namespace BankExercise.Configurations
{
    public class BankConfiguration : IEntityTypeConfiguration<Bank>
    {
        public void Configure(EntityTypeBuilder<Bank> builder)
        {
            builder.HasKey(x => x.BankId);

            builder.Property(x => x.Name)
                .IsRequired();

            builder.Property(x => x.Location)
                .IsRequired();

            builder.HasMany(x => x.Tellers)
                   .WithOne(x => x.Bank);

            builder.HasMany(x => x.Customers)
                    .WithOne(x => x.Bank);
        }

    }
}

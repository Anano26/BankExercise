using BankExercise.Classes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankExercise.Configurations
{
    public class SavingsConfiguration : IEntityTypeConfiguration<Savings>
    {
        public void Configure(EntityTypeBuilder<Savings> builder)
        {
            //builder.HasKey(x => x.Id);

            builder.Property(x => x.CustomerId)
                .IsRequired();
        }
    }
}

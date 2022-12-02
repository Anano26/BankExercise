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
    public class CheckingConfiguration : IEntityTypeConfiguration<Checking>
    {
        public void Configure(EntityTypeBuilder<Checking> builder)
        {
            //builder.HasKey(x => x.Id);

            builder.Property(x => x.CustomerId)
                .IsRequired();
        }
    }
}

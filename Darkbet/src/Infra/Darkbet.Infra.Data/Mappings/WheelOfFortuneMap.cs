using Darkbet.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Darkbet.Infra.Data.Mappings
{
    public class WheelOfFortuneMap : IEntityTypeConfiguration<WheelOfFortune>
    {
        public void Configure(EntityTypeBuilder<WheelOfFortune> builder)
        {
            builder.Property(c => c.Id).IsRequired();
            builder.Property(c => c.Color);
            builder.Property(c => c.Number);
        }
    }
}

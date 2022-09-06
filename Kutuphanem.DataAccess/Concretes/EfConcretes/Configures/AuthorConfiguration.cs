using Kutuphanem.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kutuphanem.DataAccess.Concretes.EfConcretes.Configures
{
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasKey(x => x.AuthorId);
            builder.Property(x => x.Name).HasColumnType("nvarchar(50)");
            builder.HasMany(x => x.Books).WithOne(x => x.Author);
        }
    }
}

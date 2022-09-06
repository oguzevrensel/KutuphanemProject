using Kutuphanem.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kutuphanem.DataAccess.Concretes.EfConcretes.Configures
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.CategoryId);
            builder.Property(x => x.CategoryName).HasColumnType("nvarchar(50)");
            builder.HasMany(x => x.Books).WithOne(x => x.Category);
        }
    }
}

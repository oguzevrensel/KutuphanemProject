using Kutuphanem.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kutuphanem.DataAccess.Concretes.EfConcretes.Configures
{
    public class PersonelConfiguration : IEntityTypeConfiguration<Personel>
    {
        public void Configure(EntityTypeBuilder<Personel> builder)
        {
            builder.HasKey(x => x.PersonelId);
            builder.Property(x => x.PersonelName).HasColumnType("nvarchar(50)");
            //builder.HasMany(x => x.Books).WithOne(x => x.Personel).HasForeignKey(x=>x.BookId);
            //builder.HasMany(x => x.Users).WithOne(x => x.Personel).HasForeignKey(x => x.UserId);

            //builder.HasMany(x => x.Books).WithOne(x => x.Personel).HasForeignKey(x => x.BookId);
           
        }
    }
}

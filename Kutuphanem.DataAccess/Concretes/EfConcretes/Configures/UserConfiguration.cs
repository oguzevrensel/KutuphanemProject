using Kutuphanem.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kutuphanem.DataAccess.Concretes.EfConcretes.Configures
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.UserId);
            builder.Property(x => x.UserName).HasColumnType("nvarchar(50)");

            //builder.HasMany(x => x.Books).WithOne(x => x.User).HasForeignKey(x=>x.BookId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.Personel).WithMany(x => x.Users);
        }
    }
}

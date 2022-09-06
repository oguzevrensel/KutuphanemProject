using Kutuphanem.Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace Kutuphanem.Entity.Concrete
{
    public class User : IEntity 
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }

        // Navigation Property
        public virtual HashSet<Book> Books { get; set; }
        public virtual Personel Personel { get; set; }

        // Foreign Keys
        public int BookId { get; set; }
        public int PersonelId { get; set; }

        public User()
        {
            Books = new HashSet<Book>();
        }
    }
}

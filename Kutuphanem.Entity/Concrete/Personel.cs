using Kutuphanem.Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace Kutuphanem.Entity.Concrete
{
    public class Personel : IEntity
    {
        [Key]
        public int PersonelId { get; set; }
        public string PersonelName { get; set; }

        // Navigation Properties
        public virtual HashSet<Book> Books { get; set; }
        public virtual HashSet<User> Users { get; set; }

        // Foreign Keys
        public int BookId { get; set; }
        public int UserId { get; set; }

        public Personel()
        {
            Books = new HashSet<Book>();
            Users = new HashSet<User>();
        }
    }
}

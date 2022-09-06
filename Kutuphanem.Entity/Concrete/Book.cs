using Kutuphanem.Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Kutuphanem.Entity.Concrete
{
    public class Book : IEntity
    {
        [Key]
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string ISBN { get; set; }

        // Foreign Key
        public int PersonelId { get; set; }
        public int AuthorId { get; set; }
        public int CategoryId { get; set; }
        public int UserId { get; set; }

        // Navigtaion Properties
        public virtual Author Author { get; set; }
        public virtual Category Category { get; set; }
        public virtual User User { get; set; }
        public virtual Personel Personel { get; set; }


       

    }
}

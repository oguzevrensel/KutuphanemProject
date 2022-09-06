using Kutuphanem.Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Kutuphanem.Entity.Concrete
{
    public class Author : IEntity
    {
        [Key]
        public int AuthorId { get; set; }
        public string Name { get; set; }

        // Navigation Property
        public virtual HashSet<Book> Books { get; set; }

        // Foreign Keys
        public int BookId { get; set; }

        public Author()
        {
            Books = new HashSet<Book>();
        }
    }
}

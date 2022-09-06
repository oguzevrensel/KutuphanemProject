using Kutuphanem.Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Kutuphanem.Entity.Concrete
{
    public class Category : IEntity
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        // Navigation Properties
        public virtual HashSet<Book> Books { get; set; }


        // Foreign Keys
        public int BookId { get; set; }

        public Category()
        {
            Books = new HashSet<Book>();
        }
    }
}

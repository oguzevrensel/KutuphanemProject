using Kutuphanem.Business.Abstracts;
using Kutuphanem.DataAccess.Abstracts;
using Kutuphanem.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kutuphanem.Business.Concretes
{
    public class BookService : BaseService<Book>, IBookService
    {
        public BookService(IBookRepository bookRepository) : base(bookRepository)
        {

        }
    }
}

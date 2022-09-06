using Kutuphanem.Business.Abstracts;
using Kutuphanem.DataAccess.Abstracts;
using Kutuphanem.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kutuphanem.Business.Concretes
{
    public class AuthorService : BaseService<Author>, IAuthorService
    {
        public AuthorService(IAuthorRepository authorRepository) : base(authorRepository)
        {

        }
    }
}

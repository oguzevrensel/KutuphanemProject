using Kutuphanem.DataAccess.Abstracts;
using Kutuphanem.DataAccess.Concretes.EfConcretes.Contexts;
using Kutuphanem.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kutuphanem.DataAccess.Concretes.EfConcretes
{
    public class UserRepository : BaseRepository<User, KutuphanemContext>, IUserRepository
    {
    }
}

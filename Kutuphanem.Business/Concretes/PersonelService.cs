﻿using Kutuphanem.Business.Abstracts;
using Kutuphanem.DataAccess.Abstracts;
using Kutuphanem.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kutuphanem.Business.Concretes
{
    public class PersonelService : BaseService<Personel>, IPersonelService
    {
        public PersonelService(IPersonelRepository persenelRepository) : base(persenelRepository)
        {

        }
    }
}

﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts

{    //Dal, dao
    public interface IProductDal: IEntityRepository<Product>
    {

    }
}

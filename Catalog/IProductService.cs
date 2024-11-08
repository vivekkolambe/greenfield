﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog
{
    public   interface IProductService
    {
        void Insert(Product product);
        void Update(Product product);
        void Delete(Product product);
        List<Product> GetAll();
        Product GetById(int id);

    }
}

﻿using FashionHub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionHub.DataAccess.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product obj);

        IEnumerable<Product> SearchProducts(string searchTerm, string? includeProperties = null);
    }
}

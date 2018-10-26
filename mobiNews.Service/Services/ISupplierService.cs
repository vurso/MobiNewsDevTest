using MobiNews.Data.Models;
using System;
using System.Collections;
using System.Collections.Generic;

namespace mobiNews.Service.Services
{
    public interface ISupplierService
    {
        void Create(Supplier supplier);
        Supplier GetSupplier(Func<Supplier, bool> param);
        IEnumerable<Supplier> GetSuppliers();
        void Update(Supplier supplier);
        void Delete(Supplier supplier);
    }
}

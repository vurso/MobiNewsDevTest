using MobiNews.Data.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MobiNews.Data.Repositories
{
    public interface ISupplierRepository
    {
        void Create(Supplier supplier);
        Supplier GetSupplier(Func<Supplier, bool> param);
        IEnumerable<Supplier> GetSuppliers();
        void Update(Supplier supplier);
        void Delete(Supplier supplier);
    }
}

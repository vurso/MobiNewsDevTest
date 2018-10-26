using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobiNews.Data.Models;
using MobiNews.Data.Repositories;

namespace mobiNews.Service.Services
{
    public class SupplierService : ISupplierService
    {
        private readonly ISupplierRepository _supplierRepository;

        public SupplierService(ISupplierRepository supplierRepository)
        {
            _supplierRepository = supplierRepository;
        }

        public void Create(Supplier supplier)
        {
            _supplierRepository.Create(supplier);
        }

        public void Delete(Supplier supplier)
        {
            throw new NotImplementedException();
        }

        public Supplier GetSupplier(Func<Supplier, bool> param)
        {
            return _supplierRepository.GetSupplier(param);
        }

        public IEnumerable<Supplier> GetSuppliers()
        {
            return _supplierRepository.GetSuppliers();
        }

        public void Update(Supplier supplier)
        {
            throw new NotImplementedException();
        }
    }
}

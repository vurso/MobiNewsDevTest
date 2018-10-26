using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobiNews.Data.Models;

namespace MobiNews.Data.Repositories
{
    public class SupplierRepository : BaseRepository<MobiNewsContext>, ISupplierRepository
    {
        public SupplierRepository(MobiNewsContext context) : base(context)
        {

        }

        public void Create(Supplier supplier)
        {
            Context.Suppliers.Add(supplier);
            Context.Entry(supplier).State = EntityState.Added;
            Context.SaveChanges();
        }

        public void Delete(Supplier supplier)
        {
            throw new NotImplementedException();
        }

        public Supplier GetSupplier(Func<Supplier, bool> param)
        {
            return Context.Suppliers.Where(param).FirstOrDefault();
        }

        public IEnumerable<Supplier> GetSuppliers()
        {
            return Context.Suppliers;
        }

        public void Update(Supplier supplier)
        {
            throw new NotImplementedException();
        }
    }
}

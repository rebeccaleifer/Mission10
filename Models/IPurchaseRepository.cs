using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Models
{
    public interface IPurchaseRepository
    {
        public IQueryable<Purchase>  purchases { get; }

        public void SavePurchase(Purchase purchase);
    }
}

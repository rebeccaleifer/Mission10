using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Models
{
    public interface IBookstoreRepository
    {
        IQueryable<Books>Books { get; }

        public void SaveOrder(Books b);
        public void CreateOrder(Books b);
        public void DeleteOrder(Books b);
    }
}

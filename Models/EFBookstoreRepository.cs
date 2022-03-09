﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Models
{
    public class EFBookstoreRepository: IBookstoreRepository
    {

        private BookstoreContext context { get; set; }

        public EFBookstoreRepository (BookstoreContext temp)
        {
            context = temp;
        }
        public IQueryable<Books> Books => context.Books;

        public void SaveOrder(Books b)
        {
            context.SaveChanges();
        }

        public void CreateOrder(Books b)
        {
            context.Add(b);
            context.SaveChanges();
        }

        public void DeleteOrder(Books b)
        {
            context.Remove(b);
            context.SaveChanges();
        }
    }
}

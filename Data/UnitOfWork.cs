using System;
using System.Collections.Generic;
using System.Linq;
using Model;

namespace Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private PizzaContext _context;
        public UnitOfWork(PizzaContext context)
        {
            _context = context;
        }
        public bool AddOrder(CustomerOrder customerOrder)
        {
            if(customerOrder == null)   
                return false;
            try
            {
                _context.customerOrders.Add(customerOrder);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {           
                return false;     
            }
            
        }
        public IQueryable<CustomerOrder> GetOrders()
        {
            return _context.customerOrders;
        }

        
    }
}

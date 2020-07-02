using SimpleOrderApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleOrderApp.Data
{
    class OrderRepository : IOrderRepository
    {
        private readonly SimpleOrderContext _context;

        public OrderRepository(SimpleOrderContext context)
        {
            _context = context;
        }


        public void Create(Order order)
        {
            var entities = _context.Orders
        }


        //Possible Error
        // May need to use locationEntity instead of location, thus a need for mapping
        public IEnumerable<Order> GetAll(Location location)
        {
            var entities = _context.Orders.ToList();

            return entities.Select(e => new Order(e.Quantity, location, DateTime.Now));
        }
    }
}

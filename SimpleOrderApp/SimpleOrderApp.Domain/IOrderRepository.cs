using System.Collections;
using System.Collections.Generic;

namespace SimpleOrderApp.Domain
{
    public interface IOrderRepository
    {

        //adding Location location for OrderRepository
        IEnumerable<Order> GetAll(Location location);

        void Create(Order order);
    }
}
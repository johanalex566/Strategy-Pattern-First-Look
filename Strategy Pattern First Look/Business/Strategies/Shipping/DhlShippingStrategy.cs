using Strategy_Pattern_First_Look.Business.Model;
using System;
using System.Net.Http;

namespace Strategy_Pattern_First_Look.Business.Strategies.Shipping
{
    public class DhlShippingStrategy : IShippingStrategy
    {
        public void Ship(Order order)
        {
            using (var client = new HttpClient())
            {
                /// TODO: Implement DHL Shipping Integration

                Console.WriteLine("Order is shipped with DHL");
            }
        }
    }
}

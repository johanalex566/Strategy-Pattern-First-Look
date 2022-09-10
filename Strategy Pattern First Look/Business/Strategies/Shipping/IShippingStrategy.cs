using Strategy_Pattern_First_Look.Business.Model;

namespace Strategy_Pattern_First_Look.Business.Strategies.Shipping
{
    public interface IShippingStrategy
    {
        void Ship(Order order);
    }
}

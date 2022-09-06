using Strategy_Pattern_First_Look.Business.Model;

namespace Strategy_Pattern_First_Look.Business.Strategies.SalesTax
{
    public class UnitedStatesSalesTaxStrategy : ISalesTaxStrategy
    {
        public decimal GetTaxFlor(Order order)
        {
            switch (order.ShippingDetails.DestinationState.ToLowerInvariant())
            {
                case "la": return order.TotalPrice * 0.095m;
                case "ny": return order.TotalPrice * 0.04m;
                case "nyc": return order.TotalPrice * 0.045m;
                default: return 0m;
            }
        }
    }
}

using Strategy_Pattern_First_Look.Business.Model;

namespace Strategy_Pattern_First_Look.Business.Strategies.SalesTax
{
    public interface ISalesTaxStrategy
    {
        public decimal GetTaxFlor(Order order);
    }
}

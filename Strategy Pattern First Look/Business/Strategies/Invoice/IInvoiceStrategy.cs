using Strategy_Pattern_First_Look.Business.Model;

namespace Strategy_Pattern_First_Look.Business.Strategies.Invoice
{
    public interface IInvoiceStrategy
    {
        public void Generate(Order order);
    }
}

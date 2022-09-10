using Newtonsoft.Json;
using Strategy_Pattern_First_Look.Business.Model;
using System;
using System.Net.Http;

namespace Strategy_Pattern_First_Look.Business.Strategies.Invoice
{
    public  class PrintOnDemandInvoiceStrategy : IInvoiceStrategy
    {
        public void Generate(Order order)
        {
            using (var client = new HttpClient())
            {
                var content = JsonConvert.SerializeObject(order);

                client.BaseAddress = new Uri("https://pluralsight.com");

                client.PostAsync("/print-on-demand", new StringContent(content));
            }
        }
    }
}

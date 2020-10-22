using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Models.Strategies.SalesTax
{
    public class SwedenSalesTaxStrategy : ISalesTaxStrategy
    {
        public decimal GetTaxFor(Order order)
        {
            if (order.ShippingDetails.DestinationCountry.ToLowerInvariant() == 
                order.ShippingDetails.OriginCountry.ToLowerInvariant())
            {
                return order.TotalPrice * 0.25m;
            }

            return 0;
        }
    }
}

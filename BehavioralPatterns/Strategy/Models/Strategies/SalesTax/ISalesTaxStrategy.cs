using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Models.Strategies.SalesTax
{
    public interface ISalesTaxStrategy
    {
        public decimal GetTaxFor(Order order);
    }
}
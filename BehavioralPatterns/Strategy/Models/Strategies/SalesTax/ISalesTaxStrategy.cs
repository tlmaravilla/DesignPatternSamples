using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Models.Strategies.SalesTax
{
    interface ISalesTaxStrategy
    {
        public decimal GetTaxFor(Order);
    }
}

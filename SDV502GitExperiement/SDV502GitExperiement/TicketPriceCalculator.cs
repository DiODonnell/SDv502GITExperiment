using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDV502GitExperiement
{
    public class TicketPriceCalculator
    {

        public decimal getPriceSenior(bool is2D)
  {
            if (is2D)
                return 11.5M;
            else
                return 13.0M;
        }
        public decimal getPriceChild(bool is2D)

        {
            if (is2D)
                return 11.5M;
            else
                return 13.0M;
        }
    }
}

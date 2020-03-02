using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestP2.Models
{
    public partial class Goods
    {
        public void incStock (double val)
        {
            this.Stock += val;
        }

        public bool decStock(double val)
        {
            if (this.Stock >= val)
            {
                this.Stock -= val;
                return true;
            }
            return false;
        }
    }
    public class GoodsExends
    {
    }
}
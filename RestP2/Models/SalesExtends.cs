using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace RestP2.Models
{
    [MetadataType(typeof(SalesExtends))]
    public partial class Sales
    {
        public bool Sale()
        {
            return this.Goods.decStock(this.Amount);
        }

        public double calcPrice()
        {
            return this.Amount * this.Goods.Price.Value;
        }
    }
    public class SalesExtends
    {
       [JsonIgnore]
       public virtual Goods Goods { get; set; }
    }
}
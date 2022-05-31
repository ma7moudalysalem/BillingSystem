using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bills.DBcontext
{
    public class invoice_inputs
    {
        public decimal quantity { get; set; }
        public string itemTotal { get; set; }
        public string billTotal { get; set; }

        public Item ItemObject{ get; set; }

        public invoice_inputs(decimal d,string s1,Item i)
        {
            quantity = d;
            itemTotal = s1;
            ItemObject = i;
        }
    }
}

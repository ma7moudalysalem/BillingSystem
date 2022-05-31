using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bills.DBcontext
{
    public class Invoive_items
    {
        [Key,ForeignKey("sales_invoice_obj"),Column(Order =1)]
        public int invoice_id { get; set; }
        [Key,ForeignKey("item_obj"), Column(Order = 2)]
        public int item_id { get; set; }
        [Required(ErrorMessage = "Quantity is Required")]
        [Range(0.0000001, float.MaxValue, ErrorMessage = "Quantity Must be Greater than Zero")]
        public float quantity { get; set; }
        //Navigation Property
        public virtual Sales_Invoice sales_invoice_obj { get; set; }
        public virtual Item item_obj { get; set; }
    }
}

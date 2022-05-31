using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bills.DBcontext
{
    public class Sales_Invoice
    {
        [Key]
        public int invoice_id { get; set; }
        [Required(ErrorMessage = "BILL TIME is Required")]
        [Column(TypeName = "time")]
        public TimeSpan invoice_time { get; set; }
        [Required(ErrorMessage = "BILL DATE is Required")]
        [Column(TypeName ="date")]
        public DateTime invoice_date { get; set;}
        [Range(0, float.MaxValue, ErrorMessage = "Percentage discount Must be Greater than or equal Zero")]
        public float invoice_percentage_discount { get; set; }
        [Required(ErrorMessage = "“Employee NAME is Required")]
        [ForeignKey("invoice_employee")]
        public int invoice_employee_id { get; set; }
        [Required(ErrorMessage = "CLIENT NAME is Required")]
        [ForeignKey("invoice_client")]
        public int invoice_client_id { get; set; }
        //Navigation Property
        public virtual Employee invoice_employee { get; set; }
        public virtual Client invoice_client { get; set; }
        public virtual ICollection<Invoive_items> invoive_items { get; set; }
    }
}

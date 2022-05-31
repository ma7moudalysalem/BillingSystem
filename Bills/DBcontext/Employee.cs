using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bills.DBcontext
{
    public class Employee
    {
        [Key]
        public int employee_id { get; set; }

        [Required(ErrorMessage ="Employee name is required")]
        [StringLength(150)]
        [Index(IsUnique = true)]
        public string employee_name { get; set; }

        //Navigation Property
        public virtual ICollection<Sales_Invoice> employee_Sales_Invoices { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bills.DBcontext
{
    public class Unit
    {
        [Key]
        public int unt_id { get; set; }
        [Required(ErrorMessage = "UNIT NAME is Required")]
        [StringLength(150)]
        [Index(IsUnique = true)]
        public string unt_name { get; set; }
        [StringLength(500)]
        public string unt_notes { get; set; }

        //Navigation Property
        public virtual ICollection<Item> Items { get; set; }
    }
}

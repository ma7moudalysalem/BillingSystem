using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bills.DBcontext
{
    public class Item_w
    {

        [Key]

        public int Item_ID { get; set; }

        [MaxLength(50)]

        [Required]

        [Index("ITEM NAME has already existed before", IsUnique = true)]

        public string Item_Name { get; set; }

        public decimal Selling_Price { get; set; }

        public decimal Buying_Price { get; set; }

        public string notes_item { get; set; }




        [ForeignKey("Unit_obj")]

        [Required]

        public int Unit_ID { get; set; }



        [ForeignKey("Type_Obj")]

        [Required]

        public int Type_ID { get; set; }

        public virtual Type_p Type_Obj { get; set; }

        public virtual List<Invoive_items> Invoices { get; set; }

        public virtual Unit Unit_obj { get; set; }




    }
}

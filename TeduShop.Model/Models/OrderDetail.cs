﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("OrderDetails")]
    public class OrderDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderID { set; get; }

        [Key]
        public int ProductID { set; get; }
        public int Quantity { set; get; }

        [ForeignKey("OrderID")]
        public virtual Order Orders { set; get; }
        [ForeignKey("ProductID")]
        public virtual Product Products { set; get; }
    }
}
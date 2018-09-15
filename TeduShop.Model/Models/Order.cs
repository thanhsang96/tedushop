using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(256)]
        public string CustomerAddress { set; get; }

        [Required]
        [MaxLength(256)]
        public string CustomerName { set; get; }

        [Required]
        [MaxLength(256)]
        public string CustomerEmail { set; get; }

        [Required]
        [MaxLength(256)]
        public string CustomerMoile { set; get; }
        [Required]
        [MaxLength(256)]
        public string CustomerMesage { set; get; }

        public DateTime CreateDate { set; get; }

        public string CreateBy { set; get; }
        public string PaymentMethod { set; get; }
        public string PaymentStatus { set; get; }
        public bool Status { set; get; }

        public virtual IEnumerable<ProductTag> Posts { set; get; }
    }
}
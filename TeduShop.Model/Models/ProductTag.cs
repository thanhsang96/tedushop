using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("ProductTags")]
    public class ProductTag
    {
        [Key]
        public int ProductID { set; get; }
     
        public virtual Post Posts { set; get; }
        [Key]
        [Column(TypeName ="varchar")]
        [MaxLength(50)]
        public string TagID { set; get; }
        [ForeignKey("TagID")]
        public virtual Tag Tags { set; get; }
        [ForeignKey("ProductID")]
        public virtual Product Products { set; get; }

    }
}
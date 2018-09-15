using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TeduShop.Model.Abstract;

namespace TeduShop.Model.Models
{
    [Table("Posts")]
    public class Post : Posst
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }      
        [Required]
        public int CategoryID { set; get; }
        [ForeignKey("CategoryID")]
        public virtual PostCategory PostCateroies { set; get; }
        public virtual IEnumerable<ProductTag> ProductTags { set; get; }
    }
}
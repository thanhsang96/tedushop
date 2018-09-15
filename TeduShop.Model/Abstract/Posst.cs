using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Abstract
{
    public abstract class Posst : IPosts
    {
        [MaxLength(256)]
        [Required]
        [Column(TypeName = "varchar")]
        public string Alias { get; set; }
        [MaxLength(256)]
        public string CreateBy { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? DisplayOrder { get; set; }
        public bool HomeFlag { get; set; }
        [MaxLength(256)]
        public string Image { get; set; }
        [MaxLength(256)]
        public string MetaDescription { get; set; }
        [MaxLength(256)]
        public string MetaKeyWord { get; set; }
        [MaxLength(256)]
        public string Name { get; set; }
        public int? ParentID { get; set; }
        public bool Status { get; set; }
        [MaxLength(256)]
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
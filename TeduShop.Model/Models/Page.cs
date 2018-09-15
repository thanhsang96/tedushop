﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TeduShop.Model.Abstract;

namespace TeduShop.Model.Models
{
    [Table("Pages")]
    public class Page : Auditable
    {
        [Key]
        public int ID { set; get; }

        [Required]
        [MaxLength(256)]    
        public string Name { set; get; }

        [Column(TypeName ="varchar")]
        [Required]
        [MaxLength(256)]
        public string Alias { set; get; }

        public string Content { set; get; }
    }
}
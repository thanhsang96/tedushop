﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Abstract
{
   public abstract class Auditable : IAuditable
    {
        public DateTime? CreateTime { set; get; }
        [MaxLength(256)]
        public string CreateBy { set; get; }
        public DateTime? UpdateDate { set; get; }
        [MaxLength(256)]
        public string UpdateBy { set; get; }
        [MaxLength(256)]
        public string MetaDescription { set; get; }
        [MaxLength(256)]
        public string MetaKeyWord { set; get; }
       public bool Status { set; get; }

    }
}

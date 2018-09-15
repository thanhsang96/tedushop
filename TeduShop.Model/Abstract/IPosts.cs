using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Abstract
{
   public interface IPosts
    {
         string Name { set; get; }

         string Alias { set; get; }

         int? ParentID { set; get; }
         int? DisplayOrder { set; get; }
         string Image { set; get; }
         bool HomeFlag { set; get; }
         DateTime? CreateTime { set; get; }
         string CreateBy { set; get; }
         DateTime? UpdateDate { set; get; }
         string UpdateBy { set; get; }
         string MetaDescription { set; get; }
         string MetaKeyWord { set; get; }
         bool Status { set; get; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Abstract
{
    interface IAuditable
    {
        DateTime? CreateDate { set; get; }
       
        string CreatedBy { set; get; }
        DateTime? UpdateDate { set; get; }
      
        string UpdateBy { set; get; }
        bool Status { set; get; }
        string MetaKeyword { set; get; }
        string MetaDescription { set; get; }
    }
}

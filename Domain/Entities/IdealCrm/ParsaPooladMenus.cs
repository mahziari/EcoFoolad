using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  Domain.Entities.IdealCrm
{
   public partial class ParsaPooladMenus
    {
        public int ParsaPooladMenusId { get; set; }
        public string Name { get; set; }
        public string UrlName { get; set; }
        public int? ParentMenusId { get; set; }
        public string Image { get; set; }
        public string Icon { get; set; }

        public virtual ICollection<WsproductFirstGroup> WsproductFirstGroup { get; set; }
        public virtual ICollection<CrmCompany> CrmCompany { get; set; }
    }
}

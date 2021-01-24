using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsaPoolad.Domain.Entities
{
   public partial class ParsaPooladMenus
    {
        public int ParsaPooladMenusId { get; set; }
        public string Name { get; set; }
        public int? ParentMenusId { get; set; }

        // public virtual ParsaPooladMenus ParsaPooladMenu { get; set; }
        public virtual ICollection<WsproductFirstGroup> WsproductFirstGroup { get; set; }
    }
}

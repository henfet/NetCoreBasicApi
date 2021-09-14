using NetCoreBase.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreBase.Features.Inventory.Entities
{
    public class Item : BaseEntity
    {
        public string Code { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
    }
}

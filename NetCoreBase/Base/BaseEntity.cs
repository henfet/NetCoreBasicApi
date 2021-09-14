using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreBase.Base
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid Guid { get; set; }
    }
}

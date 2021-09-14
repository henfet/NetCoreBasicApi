using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreBase.Helpers
{
    public class Response
    {
        public string SuccessMessage { get; set; }
        public string FailMessage { get; set; }
        public object Data { get; set; }
    }
}

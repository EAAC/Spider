using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spider.Type
{
    public class JsonResult
    {
        public int RecordId { get; set; }

        public string Message { get; set; }

        public bool IsSuccess { get; set; }

        public string CssClass { get; set; }

        public object Record { get; set; }
    }
}

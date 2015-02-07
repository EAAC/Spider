using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spider.Type
{
    public class OperationResult
    {
        public int RecordId { get; set; }

        public string Message { get; set; }

        public bool IsSuccess { get; set; }

        public object Record { get; set; }

        public JsonResult ToJson()
        {
            return new JsonResult
            {
                RecordId = this.RecordId,
                Message = this.Message,
                IsSuccess = this.IsSuccess,
                Record = this.Record,
                CssClass = this.IsSuccess ? "alert alert-info" : "alert alert-danger"
            };
        }
    }
}

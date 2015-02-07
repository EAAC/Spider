using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spider.Data.Orm
{
    public class ModelBase
    {
        public int Id { get; set; }

        public bool IsDeleted { get; set; }

        public int SortingNumber { get; set; }

        public DateTime AddDate { get; set; }

        public DateTime? LastUpdateDate { get; set; }

        public DateTime? DeleteDate { get; set; }
    }
}

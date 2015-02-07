using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spider.Data.Orm
{
    public class User : ModelBase
    {
        public string UserName { get; set; }

        public string Email { get; set; }

        public string FacebookId { get; set; }

        public virtual List<Video> Videos { get; set; }
    }
}

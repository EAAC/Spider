using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spider.Data.Orm
{
    public class Thumbnail : ModelBase
    {
        public string ThumbnailType { get; set; }

        public int Height { get; set; }

        public int Width { get; set; }

        public string Url { get; set; }
    }
}

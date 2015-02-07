using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spider.Data.Orm
{
    public class Video : ModelBase
    {
        public string ETag { get; set; }

        public string Kind { get; set; }

        public bool HasCaption { get; set; }

        public string Definition { get; set; }

        public string Dimension { get; set; }

        public string Duration { get; set; }

        public bool IsLicensedContent { get; set; }

        public int CategoryId { get; set; }

        public string ChannelId { get; set; }

        public string ChannelTitle { get; set; }

        public string Description { get; set; }

        public string Title { get; set; }

        public string PublishedAt { get; set; }

        public bool IsEmbeddable { get; set; }

        public string License { get; set; }

        public string PrivacyStatus { get; set; }

        public bool ArePublicStatsViewable { get; set; }

        public string UploadStatus { get; set; }

        public virtual List<Thumbnail> Thumbnails { get; set; }

        public virtual List<User> Users { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDS.Entities
{
    public class ShareItem : BaseEntity
    {
        public ShareItem()
        {
            Images = new HashSet<Image>();
        }

        public string Barcode { get; set; }
        public string CustomBarcode { get; set; }
        public int Type { get; set; }
        public string Description { get; set; }
        public string Percentage { get; set; }


        public int DownloadCount { get; set; }

        public int? CountLimit { get; set; }

        public DateTime? TimeLimit { get; set; }

        public string DetailsUrl { get; set; }

        public virtual ICollection<Image> Images { get; set; }
        public virtual Organization Organization { get; set; }
        public virtual ICollection<UserShare> UserShare { get; set; }
    }
}

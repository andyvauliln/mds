using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Newtonsoft.Json;

namespace MDS.Models
{
    public class OrganizationBaseModel 
    {
        [Required]
        public int ObjId { get; set; }

        [Required]
        public string Name { get; set; }

        public string ObjDescription { get; set; }

        public string KeyWords { get; set; }

        public string SiteUrl { get; set; }

        public DateTime? DateInNew { get; set; }

        private IList<ImageModel> images;

        public virtual IList<ImageModel> Images
        {
            get { return images ?? new List<ImageModel>(); }

            set { images = value; }
        }

        public ICollection<CategoryModel> Categories { get; set; }

        public ICollection<IBeaconModel> IBeacons { get; set; }

        public ICollection<ShopModel> Shops { get; set; }

        public int DownloadCount
        {
            get { return ShareItems.Sum(r => r.DownloadCount); }
        }

        public virtual ICollection<ShareItemModel> ShareItems { get; set; }

    }
}

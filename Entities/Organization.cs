using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MDS.Entities;

namespace MDS.Entities
{
    public class Organization : BaseEntity
    {
        public Organization()
        {
            Categories = new List<OrganizationCategory>();
            Shops = new HashSet<Shop>();
            ShareItems = new HashSet<ShareItem>();
        }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string KeyWords { get; set; }
        public string SiteUrl { get; set; }

        public DateTime? NewDate { get; set; }
        public virtual ICollection<ShareItem> ShareItems { get; set; }

        public List<OrganizationCategory> Categories { get; set; }
        public virtual ICollection<Shop> Shops { get; set; }
        public virtual ICollection<Image> Images { get; set; }
    }
}

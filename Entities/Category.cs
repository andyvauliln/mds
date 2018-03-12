using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace MDS.Entities
{

    public class Category : BaseEntity
    {
        public Category()
        {
            Organizations = new HashSet<OrganizationCategory>();
        }

        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<OrganizationCategory> Organizations { get; set; }
    }
}

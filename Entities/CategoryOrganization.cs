using System.ComponentModel.DataAnnotations.Schema;

namespace MDS.Entities
{
    [Table("CategoryOrganizations")]
    public class OrganizationCategory
    {
        public int Organization_Id { get; set; }
        public Organization Organization { get; set; }

        public int Category_Id { get; set; }
        public Category Category { get; set; }
    }
}
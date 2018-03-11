using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MDS.Entities
{
    public class UserShare : BaseEntity
    {
        [Column(Order = 0)]
        [ForeignKey("User")]
        [Required]
        public int UserID { get; set; }

        [Column(Order = 1)]
        [ForeignKey("ShareItem")]
        [Required]
        public int ShareItemID { get; set; }

        public virtual User User { get; set; }

        public virtual ShareItem ShareItem { get; set; }

        public string UniqueCode { get; set; }

    }
}

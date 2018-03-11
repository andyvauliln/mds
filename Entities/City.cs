using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDS.Entities
{
    public class Country
    {
        [Key]
        [Required]
        public virtual int Id { get; set; }

        public string Name { get; set; }

        public DateTime? CrtDate { get; set; }
    }

    public class Region 
    {
        [Key]
        [Required]
        public virtual int Id { get; set; }

        public int CountryId { get; set; }

        public string Name { get; set; }

        public DateTime? CrtDate { get; set; }

        public virtual Country Country { get; set; }
    }

    public class City
    {
        [Key]
        [Required]
        public virtual int Id { get; set; }
        public int RegionId { get; set; }

        public string Name { get; set; }

        public DateTime? CrtDate { get; set; }

        public virtual Region Region { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDS.Entities
{
    public class Image : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        public byte[] Content { get; set; }

        public string ContentType { get; set; }

        public string Prefix { get; set; }

        public int Width { get; set; }
        public int Height { get; set; }
    }
}

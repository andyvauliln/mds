using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MDS.Models
{
    public class ImageModel
    {
        [Required]
        public int ObjId { get; set; }

        [Required]
        public string Name { get; set; }

        public string ContentType { get; set; }

        public string Prefix { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }

    public class ImageWithContentModel : ImageModel
    {
        public byte[] Content { get; set; }
    }
}

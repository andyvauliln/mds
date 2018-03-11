using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace MDS.Models
{

    public class CityModel 
    {
        [Required]
        public int ObjId { get; set; }
        public string Name { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }

        public string FullName { get { return String.Format("{0}, {1}, {2}", Name, Region, Country); } }
    }
}

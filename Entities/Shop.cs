using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MDS.Entities
{
    public class Shop : BaseEntity
    {
        public string Address { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Shedule { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public virtual Organization Organization {get; set;}
    }
}

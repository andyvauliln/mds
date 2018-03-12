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

    public class IBeaconModel
    {
        public int ObjId { get; set; }
        public string UniqueId { get; set; }
        public int OrganizationId { get; set; }
        public string Major { get; set; }
        public string Minor { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string Url { get; set; }
        public string InstanceId { get; set; }
        public string Type { get; set; }

    }
}

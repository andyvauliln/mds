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

    public class NotificationTamplate : BaseEntity
    {

        public string Text { get; set; }

        public string Name { get; set; }

        public DateTime ActivationDate { get; set; }

        public DateTime DiactivationDate { get; set; }

        public string Longitude { get; set; }

        public string Latitude { get; set; }

        public int Radius { get; set; }

        public int Type { get; set; }

    }
}

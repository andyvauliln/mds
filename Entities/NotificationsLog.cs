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

    public class NotificationsLog : BaseEntity
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public string Url { get; set; }
        public string OS { get; set; }
        public int UserId { get; set; }

    }
}

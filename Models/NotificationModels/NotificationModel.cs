using Microsoft.Azure.NotificationHubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MDS.Models
{
    public class NotificationModel
    {
        public string Message { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string[] Tags { get; set; }
        public string OS {get;set;}
    }
}
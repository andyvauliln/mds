using Microsoft.Azure.NotificationHubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MDS.Models
{
    public class PushNotification
    {
        public static PushNotification Instance = new PushNotification();

        public NotificationHubClient Hub { get; set; }

        private PushNotification()
        {

            Hub = NotificationHubClient.CreateClientFromConnectionString("Endpoint=sb://shopnotificationhub.servicebus.windows.net/;SharedAccessKeyName=DefaultFullSharedAccessSignature;SharedAccessKey=9rSAxafvkYJionzY3h05rpxLbW9VNpv6Ar+x7S7T7vM=", "shopNotificationHub");
        }
    }

    public class NotificationModel
    {
        public string Message { get; set; }
        public string[] Tags { get; set; }
        public string OS {get;set;}
    }

    public class NotificationCustomModel
    {
        public string Message { get; set; }
        public int Id { get; set; }
        public string OS { get; set; }
    }

    public class NotificationTemplateBaseModel
    {
        public int ObjId { get; set; }

        public string Longitude { get; set; }

        public string Latitude { get; set; }

        public int Radius { get; set; }
    }

    public class NotificationTemplateModel: NotificationTemplateBaseModel
    {
        public string Text { get; set; }

        public string Name { get; set; }

        public DateTime ActivationDate { get; set; }

        public DateTime DiactivationDate { get; set; }

        public int Type { get; set; }

        public bool IsActive { get { return ActivationDate < DateTime.Now && DiactivationDate < DateTime.Now; } }

    }

    public enum NotificationTemplateType
    {
        ShopTemplate,
        LocationTemplate
    }
}
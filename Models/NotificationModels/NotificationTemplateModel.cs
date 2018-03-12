using System;

namespace MDS.Models
{
        public class NotificationTemplateModel: NotificationTemplateBaseModel
    {
        public string Text { get; set; }

        public string Title { get; set; }

        public string Url { get; set; }

        public string Name { get; set; }

        public DateTime ActivationDate { get; set; }

        public DateTime DiactivationDate { get; set; }

        public int Type { get; set; }

        public bool IsActive { get { return ActivationDate < DateTime.Now && DiactivationDate > DateTime.Now; } }

    }
}
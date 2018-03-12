using System;

namespace MDS.Models
{
  public class NotificationsLogModel
    {
        public int ObjId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string Url { get; set; }
        public string OS { get; set; }
        public int UserId { get; set; }
        public DateTime DateCreated { get; set; }

    }

}
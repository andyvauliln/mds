namespace MDS.Models
{
    public class UserShareModel 
    {
        public int ObjId { get; set; }
        public int UserID { get; set; }
        public int ShareItemID { get; set; }
        public bool IsActive { get; set; }
    }
}

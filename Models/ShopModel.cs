using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace MDS.Models
{
    public class ShopModel
    {
        [Required]
        public int ObjId { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Shedule { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public int OrganizationId { get; set; }
    }

    public class ShopPasModel
    {
        public string Pas { get; set; }
    }
}

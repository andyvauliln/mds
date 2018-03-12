using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MDS.Entities
{
    public class User : BaseEntity
    {
        public User()
        {
            UserShare = new HashSet<UserShare>();
        }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string OS { get; set; }
        public string LastName { get; set; }
        public int Points { get; set; }
        public int DiscountCardsMaxCount { get; set; }
        public int CouponsMaxCount { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public bool?  Male { get; set; }
        public int? CityId { get; set; }
        //public int RoleId { get; set; }

        [StringLength(30)]
        [Required]
        public string Phone { get; set; }

        public virtual City City { get; set; }
        public virtual ICollection<UserShare> UserShare { get; set; }
    }
}

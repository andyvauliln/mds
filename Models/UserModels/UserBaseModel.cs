using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using MDS.Entities;
using Newtonsoft.Json;
using System;

namespace MDS.Models
{
    public class UserBaseModel
    {
        public int ObjId { get; set; }
        public string Email { get; set; }
        public string OS { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public bool? Male { get; set; }
        public int? CityId { get; set; }
        [Required]
        public string Phone { get; set; }
        public int Points { get; set; }
        public int DiscountCardsMaxCount { get; set; }
        public int CouponsMaxCount { get; set; }

        [JsonIgnore]
        public virtual City City { get; set; }
        public virtual ICollection<ShareItemModel> ShareItems { get; set; }

        public CityModel CityModel
        {
            get { return AutoMapper.Mapper.Map<City, CityModel>(City); }
        }

    }
}

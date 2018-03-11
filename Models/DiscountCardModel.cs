using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using MDS.Entities;


namespace MDS.Models
{
    public class DiscountCardModel: ShareItemModel 
    {

        public ImageModel BackImage
        {
            get { return Images.FirstOrDefault(r => r.Prefix == "Back"); }
        }
        public ImageModel FrontImage
        {
            get { return Images.FirstOrDefault(r => r.Prefix == "Front"); }
        }

        [JsonIgnore]
        public override IList<ImageModel> Images
        {
            get { return images ?? new List<ImageModel>(); }
            set { images = value; }
        }

    }
}

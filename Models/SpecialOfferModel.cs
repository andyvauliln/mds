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
    public class SpecialOfferModel : ShareItemModel 
    {
        public ImageModel Image
        {
            get { return Images.FirstOrDefault(); }
        }

        [JsonIgnore]
        public override IList<ImageModel> Images
        {
            get { return images ?? new List<ImageModel>(); }
            set { images = value; }
        }


    }
}

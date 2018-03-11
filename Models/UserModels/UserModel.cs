using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using MDS.Entities;
using Newtonsoft.Json;
using System;

namespace MDS.Models
{
    public class UserModel : UserBaseModel
    {
       

        private ICollection<ShareItemModel> shareItem;

        [JsonIgnore]
        public override ICollection<ShareItemModel> ShareItems
        {
            get { return shareItem.Where(r => (!r.TimeLimit.HasValue || r.TimeLimit > DateTime.Now) && (!r.CountLimit.HasValue || r.DownloadCount <= r.CountLimit)).OrderByDescending(r => r.DateInNew).ToList(); }
            set { shareItem = value; }
        }

        public IEnumerable<DiscountCardModel> DiscountCards
        {
            get
            {
                return
                    ShareItems.Where(r => r.Type == (int)ShareType.DiscountCard)
                        .Select(r => AutoMapper.Mapper.Map<ShareItemModel, DiscountCardModel>(r));
            }
        }

        public IEnumerable<CouponModel> Coupons
        {
            get { return ShareItems.Where(r => r.Type == (int)ShareType.Coupon).Select(r => AutoMapper.Mapper.Map<ShareItemModel, CouponModel>(r)); }
        }

        public IEnumerable<SpecialOfferModel> SpecialOffers
        {
            get { return ShareItems.Where(r => r.Type == (int)ShareType.SpecialOffer).Select(r => AutoMapper.Mapper.Map<ShareItemModel, SpecialOfferModel>(r)); }
        }
        public IEnumerable<CertificateModel> Certificates
        {
            get { return ShareItems.Where(r => r.Type == (int)ShareType.Certificate).Select(r => AutoMapper.Mapper.Map<ShareItemModel, CertificateModel>(r)); }
        }
                 
    }
}

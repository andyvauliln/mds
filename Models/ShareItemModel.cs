using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using MDS.Entities;


namespace MDS.Models
{
    public class ShareItemModel 
    {
        public ShareItemModel() { }
        public ShareItemModel(ShareItem share,  DateTime dateInNew, string uniqueCode)
        {
            //Todo make it via mapper
            ObjId = share.Id;
            Barcode = share.Barcode;
            CustomBarcode = CustomBarcode;
            Type = share.Type;
            ObjDescription = share.Description;
            Percentage = share.Percentage;
            images = AutoMapper.Mapper.Map<IEnumerable<Image>, IList<ImageModel>>(share.Images) ?? new List<ImageModel>();
            OrganizationId = share.Organization.Id;
            OrganizationName = share.Organization.Name;
            DateInNew = dateInNew;
            UniqueCode = uniqueCode;
            DownloadCount = share.DownloadCount;
        }

        public int OrganizationId { get; set; }

        public string OrganizationName { get; set; }

        protected IList<ImageModel> images;

        [Required]
        public int ObjId { get; set; }
        public string Barcode { get; set; }
        public string CustomBarcode { get; set; }
        public int Type { get; set; }
        public DateTime DateInNew { get; set; }
        public string ObjDescription { get; set; }
        public string Percentage { get; set; }

        public int? CountLimit { get; set; }

        public int DownloadCount { get; set; }

        public DateTime? TimeLimit { get; set; }

        public string DetailsUrl { get; set; }

        public virtual  IList<ImageModel> Images 
        {
            get { return images ?? new List<ImageModel>(); }
            set { images = value; }
        }

        public string UniqueCode { get; set; }
    }
}

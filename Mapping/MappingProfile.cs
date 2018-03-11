using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using MDS.Models;
using MDS.Entities;

namespace MDS.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Category, CategoryModel>().
                ForMember(dest => dest.ObjId, opt => opt.MapFrom(src => src.Id)).
                ForMember(dest => dest.ObjDescription, opt => opt.MapFrom(src => src.Description));
            CreateMap<Organization, OrganizationModel>().
                ForMember(dest => dest.ObjId, opt => opt.MapFrom(src => src.Id)).
                ForMember(dest => dest.DateInNew, opt => opt.MapFrom(src => src.NewDate)).
                ForMember(dest => dest.Categories, opt => opt.MapFrom(src => src.Categories)).
                ForMember(dest => dest.Shops, opt => opt.MapFrom(src => src.Shops)).
                ForMember(dest => dest.Images, opt => opt.MapFrom(src => src.Images)).
                ForMember(dest => dest.ShareItems, opt => opt.MapFrom(src => src.ShareItems)).
                ForMember(dest => dest.ObjDescription, opt => opt.MapFrom(src => src.Description));
            CreateMap<Organization, OrganizationBaseModel>().
               ForMember(dest => dest.ObjId, opt => opt.MapFrom(src => src.Id)).
               ForMember(dest => dest.ShareItems, opt => opt.MapFrom(src => src.ShareItems)).
               ForMember(dest => dest.DateInNew, opt => opt.MapFrom(src => src.NewDate)).
               ForMember(dest => dest.ObjDescription, opt => opt.MapFrom(src => src.Description));
            CreateMap<ShareItem, ShareItemModel>().
                ForMember(dest => dest.ObjId, opt => opt.MapFrom(src => src.Id)).
                ForMember(dest => dest.ObjDescription, opt => opt.MapFrom(src => src.Description)).
                ForMember(dest => dest.DateInNew, opt => opt.MapFrom(src => src.DateCreated));
            CreateMap<Shop, ShopModel>().
               // ForMember(dest => dest.OrganizationId, opt => opt.MapFrom(src => src.Organization.Id)).
                ForMember(dest => dest.ObjId, opt => opt.MapFrom(src => src.Id));
            CreateMap<User, UserModel>().
            ForMember(dest => dest.ObjId, opt => opt.MapFrom(src => src.Id)).
                ForMember(dest => dest.ShareItems, opt => opt.MapFrom(src => src.UserShare.Select(r => new ShareItemModel(r.ShareItem, r.DateCreated, r.UniqueCode)).ToList()));
            CreateMap<User, UserBaseModel>().
               ForMember(dest => dest.ObjId, opt => opt.MapFrom(src => src.Id)).
               ForMember(dest => dest.ShareItems, opt => opt.MapFrom(src => src.UserShare.Select(r => new ShareItemModel(r.ShareItem, r.DateCreated, r.UniqueCode)).ToList()));
            CreateMap<Image, ImageModel>().
                ForMember(dest => dest.ObjId, opt => opt.MapFrom(src => src.Id));
            CreateMap<UserShare, UserShareModel>().
                ForMember(dest => dest.ObjId, opt => opt.MapFrom(src => src.Id));

            CreateMap<City, CityModel>().
               ForMember(dest => dest.ObjId, opt => opt.MapFrom(src => src.Id)).
               ForMember(dest => dest.Country, opt => opt.MapFrom(src => src.Region.Country.Name)).
               ForMember(dest => dest.Region, opt => opt.MapFrom(src => src.Region.Name));

            CreateMap<ShareItemModel, DiscountCardModel>();
            CreateMap<ShareItemModel, CertificateModel>();
            CreateMap<ShareItemModel, SpecialOfferModel>();
            CreateMap<ShareItemModel, CouponModel>();
            CreateMap<NotificationTamplate, NotificationTemplateModel>().
                 ForMember(dest => dest.ObjId, opt => opt.MapFrom(src => src.Id));
            CreateMap<NotificationTamplate, NotificationTemplateBaseModel>().
                ForMember(dest => dest.ObjId, opt => opt.MapFrom(src => src.Id));




            CreateMap<UserModel, User>().
                ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ObjId));
            CreateMap<UserBaseModel, User>().
               ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ObjId));
            CreateMap<CategoryModel, Category>().
                ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ObjId)).
                ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.ObjDescription));
            CreateMap<OrganizationModel, Organization>().
                ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ObjId)).
                ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.ObjDescription)).
                ForMember(dest => dest.NewDate, opt => opt.MapFrom(src => src.DateInNew));
            CreateMap<OrganizationBaseModel, Organization>().
               ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ObjId)).
               ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.ObjDescription)).
               ForMember(dest => dest.NewDate, opt => opt.MapFrom(src => src.DateInNew));
            CreateMap<ShareItemModel, ShareItem>().
                ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ObjId)).
                ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.ObjDescription)).
                ForMember(dest => dest.DateCreated, opt => opt.MapFrom(src => src.DateInNew));
            CreateMap<ShopModel, Shop>().
                ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ObjId));
            CreateMap<UserModel, User>().
                ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ObjId));
            CreateMap<ImageModel, Image>().
                ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ObjId));
            CreateMap<UserShareModel, UserShare>().
               ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ObjId));

            CreateMap<NotificationTemplateModel, NotificationTamplate>().
               ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ObjId));
        }

    }
}
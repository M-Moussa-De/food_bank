using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DonationApp.Data.Entities;
using DonationApp.Models;

namespace DonationApp.Data
{
    public class DonationAppMappingProfile : Profile
    {
        public DonationAppMappingProfile()
        {
            CreateMap<City, CityViewModel>().ReverseMap();

            CreateMap<District, DistrictViewModel>()
            .ForMember(o => o.CityName, ex => ex.MapFrom(i => i.City.Name))
            .ForMember(o => o.CityNameEn, ex => ex.MapFrom(i => i.City.NameEn))
            .ForMember(o => o.CityId, ex => ex.MapFrom(i => i.City.Id))
            .ReverseMap()
            .ForMember(m => m.City, opt => opt.Ignore());

            CreateMap<Entities.Donation, DonationViewModel>()
        .ForMember(o => o.UserName, ex => ex.MapFrom(i => i.User.UserName))
        .ForMember(o => o.UserId, ex => ex.MapFrom(i => i.User.Id))
        .ForMember(o => o.CityId, ex => ex.MapFrom(i => i.City.Id))
        .ForMember(o => o.CityName, ex => ex.MapFrom(i => i.City.Name))
        .ForMember(o => o.CityNameEn, ex => ex.MapFrom(i => i.City.NameEn))
        .ForMember(o => o.DistrictId, ex => ex.MapFrom(i => i.District.Id))
        .ForMember(o => o.DistrictName, ex => ex.MapFrom(i => i.District.Name))
        .ForMember(o => o.DistrictNameEn, ex => ex.MapFrom(i => i.District.NameEn))
        .ForMember(o => o.DonationAttachmentViewModels, ex => ex.MapFrom(i => i.DonationAttachments))
        .ReverseMap()
        .ForMember(m => m.User, opt => opt.Ignore())
        .ForMember(m => m.City, opt => opt.Ignore())
        .ForMember(m => m.District, opt => opt.Ignore())
        .ForMember(dest => dest.DonationAttachments, opt => opt.MapFrom(src => src.DonationAttachmentViewModels));

            CreateMap<DonationAttachment, DonationAttachmentViewModel>()
                .ForMember(o => o.Src, ex => ex.MapFrom(i => Utilities.Compression.Decompress(i.Src)))
                .ReverseMap()
                .ForMember(m => m.Donation, opt => opt.Ignore());
        }
    }
}

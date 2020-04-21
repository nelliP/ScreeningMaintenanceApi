using AutoMapper;
using api = ScreeningMaintenance.Api.Models;
using ScreeningMaintenance.DataAccess.Models;

namespace ScreeningMaintenance.Api.Utilities
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //CreateMap<TSource, TDestination>()  
            CreateMap<Invitation, api.Invitation>()
                .ForMember(destination => destination.teamOrgbet,
                        opts => opts.MapFrom(source => source.Orgbet))
                .ReverseMap();

            CreateMap<Maintenance, api.Maintenance>()
               .ForMember(destination => destination.Invitation,
                       opts => opts.MapFrom(source => source.Invitation))
               .ReverseMap();

            CreateMap<Maintenances, api.Maintenances>()
               .ForMember(destination => destination.Invitations,
                       opts => opts.MapFrom(source => source.Invitations))
               .ReverseMap();
        }
      }
}

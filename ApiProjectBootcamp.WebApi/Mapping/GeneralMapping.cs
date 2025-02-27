using ApiProjectBootcamp.WebApi.Dtos.FeatureDtos;
using ApiProjectBootcamp.WebApi.Dtos.MessageDtos;
using ApiProjectBootcamp.WebApi.Entities;
using AutoMapper;

namespace ApiProjectBootcamp.WebApi.Mapping
{
    public class GeneralMapping : Profile  // Miras alınan Profile class'ı AutoMapper paketinden geliyor.
    {
        public GeneralMapping()
        {
            CreateMap<Feature, ResultFeatureDto>().ReverseMap();
            CreateMap<Feature, CreateFeatureDto>().ReverseMap();
            CreateMap<Feature, UpdateFeatureDto>().ReverseMap();
            CreateMap<Feature, GetByIdFeatureDto>().ReverseMap();

            CreateMap<Message, ResultMessageDto>().ReverseMap();
            CreateMap<Feature, CreateMessageDto>().ReverseMap();
            CreateMap<Feature, UpdateMessageDto>().ReverseMap();
            CreateMap<Feature, GetByIdMessageDto>().ReverseMap();
        }
    }
}

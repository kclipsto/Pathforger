using AutoMapper;
using Pathforger.Entities.Entities.Backgrounds;
using PathforgerApi.Dtos.Backgrounds;

namespace Pathforger.Infrastructure.Profiles;

public class BackgroundMappingProfile : Profile
{
    public BackgroundMappingProfile()
    {
        // Mapping from BackgroundDto to BackgroundEntity
        CreateMap<BackgroundDto, BackgroundEntity>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))  // Mapping Id to Key
            .ForMember(dest => dest.Img, opt => opt.MapFrom(src => src.Img))
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Type))
            // Flattened mapping for the system properties
            .ForMember(dest => dest.Boosts0, opt => opt.MapFrom(src => src.System.Boosts.Zero.Value))
            .ForMember(dest => dest.Boosts1, opt => opt.MapFrom(src => src.System.Boosts.One.Value))
            .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.System.Description.Value))
            .ForMember(dest => dest.Feats, opt => opt.MapFrom(src => MapBackgroundFeatEntities(src.System.Feats)))
            .ForMember(dest => dest.TrainedSkillsCustom, opt => opt.MapFrom(src => src.System.TrainedSkills.Custom))
            .ForMember(dest => dest.TrainedSkillsLore, opt => opt.MapFrom(src => src.System.TrainedSkills.Lore))
            .ForMember(dest => dest.TrainedSkillsValue, opt => opt.MapFrom(src => src.System.TrainedSkills.Value))
            .ForMember(dest => dest.TraitsRarity, opt => opt.MapFrom(src => src.System.Traits.Rarity))
            .ForMember(dest => dest.TraitsValue, opt => opt.MapFrom(src => src.System.Traits.Value))
            .ForMember(dest => dest.BackgroundRules, opt => opt.MapFrom(src => src.System.Rules));  // Flattened rules

        // Mapping from BackgroundFeatDto to BackgroundFeatEntity
        CreateMap<BackgroundFeatDto, BackgroundFeatEntity>()
            .ForMember(dest => dest.Img, opt => opt.MapFrom(src => src.Img))
            .ForMember(dest => dest.Level, opt => opt.MapFrom(src => src.Level))
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            .ForMember(dest => dest.Uuid, opt => opt.MapFrom(src => src.Uuid));

        // Mapping from Dictionary<string, BackgroundFeatDto> to IList<BackgroundFeatEntity>
        CreateMap<Dictionary<string, BackgroundFeatDto>, IList<BackgroundFeatEntity>>()
            .ConvertUsing((src, dest, context) => 
                src.Values.Select(featDto => context.Mapper.Map<BackgroundFeatEntity>(featDto)).ToList());
    }

    // Helper method to map items to BackgroundFeatEntities
    private IList<BackgroundFeatEntity> MapBackgroundFeatEntities(Dictionary<string, BackgroundFeatDto> items)
    {
        return items?.Values.Select(item => new BackgroundFeatEntity
        {
            Img = item.Img,
            Level = item.Level,
            Name = item.Name,
            Uuid = item.Uuid
        }).ToList() ?? new List<BackgroundFeatEntity>();
    }
}


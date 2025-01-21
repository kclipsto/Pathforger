using PathforgerApi.Dtos.Backgrounds;
using PathforgerDb.Entities.Backgrounds;

namespace PathforgerApi.Profiles;

using AutoMapper;

public class BackgroundProfile : Profile
{
    public BackgroundProfile()
    {
        CreateMap<BackgroundDto, BackgroundEntity>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.Img, opt => opt.MapFrom(src => src.Img))
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Type))
            
            // Flatten publication fields
            .ForMember(dest => dest.PublicationLicense, opt => opt.MapFrom(src => src.System.Publication.License))
            .ForMember(dest => dest.PublicationRemaster, opt => opt.MapFrom(src => src.System.Publication.Remaster))
            .ForMember(dest => dest.PublicationTitle, opt => opt.MapFrom(src => src.System.Publication.Title))

            // Flatten boosts => "0" => Boosts0, "1" => Boosts1
            .ForMember(dest => dest.Boosts0, opt => opt.MapFrom(src => src.System.Boosts.Zero.Value))
            .ForMember(dest => dest.Boosts1, opt => opt.MapFrom(src => src.System.Boosts.One.Value))

            // Description
            .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.System.Description.Value))

            // TrainedSkills
            .ForMember(dest => dest.TrainedSkillsCustom, opt => opt.MapFrom(src => src.System.TrainedSkills.Custom))
            .ForMember(dest => dest.TrainedSkillsLore, opt => opt.MapFrom(src => src.System.TrainedSkills.Lore))
            .ForMember(dest => dest.TrainedSkillsValue, opt => opt.MapFrom(src => src.System.TrainedSkills.Value))

            // Traits
            .ForMember(dest => dest.TraitsRarity, opt => opt.MapFrom(src => src.System.Traits.Rarity))
            .ForMember(dest => dest.TraitsValue, opt => opt.MapFrom(src => src.System.Traits.Value))

            // Example of flattening 'Rules' if you want them as strings
            .ForMember(dest => dest.BackgroundRules, opt => opt.MapFrom(src =>
                src.System.Rules.Select(r => $"{r.Key}:{r.Uuid}").ToList()))

            // If you don't want to reverse map, skip ReverseMap()
            .ReverseMap();
    }
}

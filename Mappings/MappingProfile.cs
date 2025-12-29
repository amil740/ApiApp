using AutoMapper;
using ApiProject.Models;
using ApiProject.DTOs.Event;
using ApiProject.DTOs.Organizer;
using ApiProject.DTOs.Ticket;

namespace ApiProject.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Event, EventDto>()
                .ForMember(dest => dest.OrganizerName, opt => opt.MapFrom(src => src.Organizer.Name));
            CreateMap<EventCreateDto, Event>();
            CreateMap<Organizer, OrganizerDto>()
                .ForMember(dest => dest.Events, opt => opt.MapFrom(src => src.Event));
            CreateMap<CreateOrganizerDto, Organizer>();

            CreateMap<Ticket, TicketDto>()
                .ForMember(dest => dest.EventName, opt => opt.MapFrom(src => src.Event.Title));
            CreateMap<CreateTicketDto, Ticket>();
        }
    }
}

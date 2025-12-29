using ApiProject.DTOs.Event;

namespace ApiProject.DTOs.Organizer
{
    public class OrganizerDto
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public string? Phone { get; set; }
        public string? LogoUrl { get; set; }
        public List<EventDto>? Events { get; set; }
    }

    public class CreateOrganizerDto
    {
        public required string Name { get; set; }
        public required string Email { get; set; }
        public string? Phone { get; set; }
    }
}

namespace ApiProject.DTOs.Ticket
{
    public class TicketDto
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Type { get; set; }
        public decimal Price { get; set; }
        public int EventId { get; set; }
        public string? EventName { get; set; }
    }

    public class CreateTicketDto
    {
        public required string Title { get; set; }
        public required string Type { get; set; }
        public decimal Price { get; set; }
        public int EventId { get; set; }
    }
}

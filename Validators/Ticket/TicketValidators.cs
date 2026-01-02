using ApiProject.DTOs.Ticket;
using FluentValidation;

namespace ApiProject.Validators.Ticket;

public class CreateTicketValidator : AbstractValidator<CreateTicketDto>
{
    public CreateTicketValidator()
    {
        RuleFor(x => x.Title)
            .NotEmpty()
            .WithMessage("Title bos ola bilmez")
            .MaximumLength(100)
            .WithMessage("Title 100 chardan cox ola bilmez");

        RuleFor(x => x.Type)
            .NotEmpty()
            .WithMessage("Type bos ola bilmez")
            .MaximumLength(50)
            .WithMessage("Type 50 chardan cox ola bilmez");

        RuleFor(x => x.Price)
            .GreaterThan(0)
            .WithMessage("Price musb?t olmal?d?r");

        RuleFor(x => x.EventId)
            .GreaterThan(0)
            .WithMessage("EventId düzgün deyil");
    }
}

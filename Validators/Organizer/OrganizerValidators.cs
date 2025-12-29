using ApiProject.DTOs.Organizer;
using FluentValidation;

namespace ApiProject.Validators.Organizer;

public class OrganizerValidators:AbstractValidator<CreateOrganizerDto>
{
    public OrganizerValidators()
    {
        RuleFor(x => x.Name)
            .NotEmpty()
            .WithMessage("Name bos ola bilmez")
            .MaximumLength(100)
            .WithMessage("Name 100 chardan cox ola bilmez");
        RuleFor(x => x.Email)
            .NotEmpty()
            .WithMessage("Email bos ola bilmez")
            .MaximumLength(100)
            .WithMessage("Email 100 chardan cox ola bilmez")
            .EmailAddress()
            .WithMessage("Duzgun email daxil edilmeyib");
        RuleFor(x=>x.Phone)
            .MaximumLength(20)
            .WithMessage("Phone 20 chardan cox ola bilmez");
    }
}

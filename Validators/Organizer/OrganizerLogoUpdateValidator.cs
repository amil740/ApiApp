using ApiProject.DTOs.Organizer;
using FluentValidation;

namespace ApiProject.Validators.Organizer;

public class OrganizerLogoUpdateValidator : AbstractValidator<OrganizerLogoUpdateDto>
{
    public OrganizerLogoUpdateValidator()
    {
        RuleFor(x => x.LogoUrl)
            .NotEmpty().WithMessage("LogoUrl bos ola bilmez")
            .Must(BeImageFile).WithMessage("Yalniz shekil fayli yuklenmelidir (.jpg, .jpeg, .png, .gif)");
    }

    private bool BeImageFile(string? path)
    {
        if (string.IsNullOrEmpty(path)) return false;
        var allowed = new[] { ".jpg", ".jpeg", ".png", ".gif" };
        return allowed.Any(ext => path.ToLower().EndsWith(ext));
    }
}

using ApiProject.DTOs.Event;
using FluentValidation;

namespace ApiProject.Validators.Event;

public class EventBannerUpdateValidator : AbstractValidator<EventBannerUpdateDto>
{
    public EventBannerUpdateValidator()
    {
        RuleFor(x => x.BannerImageUrl)
            .NotEmpty().WithMessage("BannerImageUrl bos ola bilmez")
            .Must(BeImageFile).WithMessage("Yalniz shekil fayli yuklenmelidir (.jpg, .jpeg, .png, .gif)");
    }

    private bool BeImageFile(string? path)
    {
        if (string.IsNullOrEmpty(path)) return false;
        var allowed = new[] { ".jpg", ".jpeg", ".png", ".gif" };
        return allowed.Any(ext => path.ToLower().EndsWith(ext));
    }
}

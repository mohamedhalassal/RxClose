namespace RxCloseAPI.Contracts.Pharmacies;

public class LoginRequestValidator : AbstractValidator<PharmacyRequest>
{
    public LoginRequestValidator()
    {
        RuleFor(x => x.Email)
            .NotEmpty();

        RuleFor(x => x.UserName)
            .NotEmpty();

        RuleFor(x => x.Name)
            .NotEmpty();

        RuleFor(x => x.PhoneNumber)
            .NotEmpty();

        RuleFor(x => x.Password)
            .NotEmpty()
            .WithMessage("Add Your Password")
            .MinimumLength(8);
    }
}

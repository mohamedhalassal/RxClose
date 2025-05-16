namespace RxCloseAPI.Conntracts.Validations;

public class CreatUserRequestValidator:AbstractValidator<CreatUserRequest>
{
    public CreatUserRequestValidator()
    {
        RuleFor(x => x.Email)
            .NotEmpty();

        RuleFor(x => x.Password)
            .NotEmpty()
            .WithMessage("Add Your Password")
            .MinimumLength(8);
    }
}

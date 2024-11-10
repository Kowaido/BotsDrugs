using Domain.Entities;
using FluentValidation;
using System.Text.RegularExpressions;

namespace Domain.Validators;

public class CountryValidator : AbstractValidator<Country>
{
    public CountryValidator()
    {
        //Валидация Name
        RuleFor(c => c.Name)
            .NotNull().WithMessage(ValidationMessage.NotNull)
            .NotEmpty().WithMessage(ValidationMessage.NotEmpty)
            .Length(2, 100).WithMessage(ValidationMessage.WrongLenght)
            .Matches("^[a-zA-Z]+$").WithMessage(ValidationMessage.InvalidCharacters);

        //Валидация Code
        RuleFor(c => c.Code)
            .NotNull().WithMessage(ValidationMessage.NotNull)
            .NotEmpty().WithMessage(ValidationMessage.NotEmpty)
            .Must(BeValidCountryCode).WithMessage("Поле должно состоять из 2 заглавных букв");
    }

    private bool BeValidCountryCode(string countryCode)
    {
        return countryCode != null && Regex.IsMatch(countryCode, "^[A-Z]{2}$");
    }
}
using System.Text.RegularExpressions;
using Domain.Entities;
using FluentValidation;

namespace Domain.Validators;

public class DrugValidator : AbstractValidator<Drug>
{
    public DrugValidator()
    {
        //Валидация Name
        RuleFor(d => d.Name)
            .NotNull().WithMessage(ValidationMessage.NotNull)
            .NotEmpty().WithMessage(ValidationMessage.NotEmpty)
            .Length(2, 150).WithMessage(ValidationMessage.WrongLenght)
            .Matches("^[a-zA-Z]+$").WithMessage(ValidationMessage.InvalidCharacters);

        //Валидация Manufacture
        RuleFor(drug => drug.Manufacturer)
            .NotNull().WithMessage(ValidationMessage.NotNull)
            .NotEmpty().WithMessage(ValidationMessage.NotEmpty)
            .Length(2, 100).WithMessage(ValidationMessage.WrongLenght)
            .Matches("^[a-zA-Z\\-]+$").WithMessage(ValidationMessage.InvalidCharacters);
        
        //Валидация CountryCodeId
        RuleFor(expression: d => d.CountryCodeId)
            .NotNull().WithMessage(ValidationMessage.NotNull)
            .NotEmpty().WithMessage(ValidationMessage.NotEmpty)
            .Must(BeValidCountryCode).WithMessage("Указанный код странны не существует");
    }

    /// <summary>
    /// Метод на проверку валидацию кода страны
    /// </summary>
    /// <param name="countryCode"></param>
    /// <returns></returns>
    private bool BeValidCountryCode(string countryCode)
    {
        //Проверка на 2 заглавные буквы
        return countryCode != null && Regex.IsMatch(countryCode, "^[A-Z]{3}$");
    }
}
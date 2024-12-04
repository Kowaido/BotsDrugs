using Domain.Entities;
using FluentValidation;

namespace Domain.Validators;

public class DrugItemValidator : AbstractValidator<DrugItem>
{
    public DrugItemValidator()
    {
        //Валидация Cost
        RuleFor(di => di.Cost)
            .NotNull().WithMessage(ValidationMessage.NotNull)
            .NotEmpty().WithMessage(ValidationMessage.NotEmpty)
            .GreaterThan(0).WithMessage(ValidationMessage.PositiveInteger)
            .ScalePrecision(2, 15).WithMessage("Поле должно содержать не более двух знаков после запятой и быть положительным");

        //Валидация Count
        RuleFor(di => di.Count)
            .NotNull().WithMessage(ValidationMessage.NotNull)
            .GreaterThanOrEqualTo(0).WithMessage(ValidationMessage.PositiveInteger)
            .LessThanOrEqualTo(10000).WithMessage("Количество не должно превышать 10000");

        //Валидация DrugId
        RuleFor(di => di.DrugId)
            .NotNull().WithMessage(ValidationMessage.NotNull)
            .NotEmpty().WithMessage(ValidationMessage.NotEmpty);

        //Валидация DrugStoreId
        RuleFor(di => di.DrugStoreId)
            .NotNull().WithMessage(ValidationMessage.NotNull)
            .NotEmpty().WithMessage(ValidationMessage.NotEmpty);
    }
    
}
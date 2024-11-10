namespace Domain.Validators;

public static class ValidationMessage
{
    public const string NotNull = "{PropertyName} не может быть null}";
    public const string NotEmpty = "{PropertyName} не может быть пустым}";
    public const string WrongLenght = "{PropertyName} не может иметь ошибочную длину от {min} до {max}}";
    public const string PositiveInteger = "{PropetyName} должно быть позитивное число";
    public const string IsRight = "{PropertyName} не корректно";
    public const string InvalidCharacters = "{PropertyName} должно содержать только буквы и пробелы";
}
using System.Runtime.InteropServices.JavaScript;
using System.Text.Json.Serialization.Metadata;
using Domain.Validators;
using Domain.ValueObjects;
using FluentValidation;

namespace Domain.Entities
{
    /// <summary>
    /// Лекарственный препарат
    /// </summary>
    public class Drug : BaseEntity
    {
        public Drug(string name, string manufacturer, string countryCodeId, Country country)
        {
            Name = name;
            Manufacturer = manufacturer;
            CountryCodeId = countryCodeId;
            Country = country;
        }

        /// <summary>
        /// Название препарата.
        /// </summary>
        public string Name { get; private set; }
        
        /// <summary>
        /// Производитель препарата.
        /// </summary>
        public string Manufacturer { get; private set; }
        
        /// <summary>
        /// Код страны производителя.
        /// </summary>
        public string CountryCodeId { get; private set; }

        /// <summary>
        /// Справочник стран
        /// </summary>
        public Dictionary<string, string> countryCode = new Dictionary<string, string>
        {
            {"RU", "Россия"}, {"FR", "Франция"}, {"MD", "Молдова"}, {"JP", "Япония"}, {"EU", "Европа"}, {"IN", "Индия"}, 
            {"BR", "Бразилия"}, {"CN", "Китай"}, {"CA", "Канада"}, {"DE", "Германия"}, {"GB", "Великобритания"},
            {"US", "Соединённые Штаты"}
        };
        
        // Навигационное свойство для связи с объектом Country
        public Country Country { get; private set; }
        
        // Навигационное свойство для связи с DrugItem
        public ICollection<DrugItem> DrugItems { get; private set; } = new List<DrugItem>();

        /// <summary>
        /// Метод для проверки, страны в справочнике
        /// </summary>
        private void CheckCountry()
        {
            if (countryCode.ContainsKey(CountryCodeId))
            {
                Console.WriteLine($"Страна с кодом {CountryCodeId}: {countryCode[CountryCodeId]}");
            }

            else
            {
                Console.WriteLine("Страна с таким кодом не найдена");
            }
        }

        /// <summary>
        /// Метод для ввода страны и проверки её
        /// </summary>
        public void AnswerMethod()
        {
            Console.Write("Введите код страны: ");
            CountryCodeId = Console.ReadLine();
            CheckCountry();
        }
    }
}
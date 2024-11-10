using Domain.Entities;

namespace Domain.ValueObjects
{
    /// <summary>
    /// Объект значения, представляющий адрес.
    /// </summary>
    public class Address : BaseValueObject
    {
        /// <summary>
        /// Конструктор для инициализации адреса.
        /// </summary>
        /// <param name="city">Город.</param>
        /// <param name="street">Улица.</param>
        /// <param name="house">Номер дома.</param>
        /// <param name="postalCode">Почтовый индекс.</param>
        public Address(string city, string street, string house, string postalCode)
        {
            City = city;
            Street = street;
            House = house;
            PostalCode = postalCode;
        }
        
        /// <summary>
        /// Город.
        /// </summary>
        public string City { get; private set; }

        /// <summary>
        /// Улица.
        /// </summary>
        public string Street { get; private set; }

        /// <summary>
        /// Номер дома.
        /// </summary>
        public string House { get; private set; }
        
        /// <summary>
        /// Почтовый Индекс
        /// </summary>
        public string PostalCode { get; private set; }
        
        /// <summary>
        /// Страна
        /// </summary>
        public string Country{get;private set;}

        /// <summary>
        /// Таблица ISO
        /// </summary>
        HashSet<string> IsoCountryCode = new HashSet<string>
        {
            "RU", "US", "FR", "DE", "GB", "IN", "CN", "JP", "BR", "CA", "MD", "EU"
        };

        /// <summary>
        /// Метод отвечающий за ISO страны
        /// </summary>
        private void ISOCountry()
        {
            Console.Write("Введите ISO страны: ");
            Country = Console.ReadLine();
            if (IsoCountryCode.Contains(Country))
            {
                Console.Write($"Код страны: {Country}");
                Console.WriteLine("Вся информация.");
                ToString();
            }

            else
            {
                Console.Write("Код страны не найден.");
            }
        }

        public void PrintAddress()
        {
            ISOCountry();
        }

        /// <summary>
        /// Возвращает строковое представление адреса.
        /// </summary>
        /// <returns>Строка, представляющая адрес.</returns>
        public override string ToString()
        {
            return $"Город-{City}, Улица-{Street}, Дом-{House}, Почтовый Индекс{PostalCode}, Страна-{Country}";
        }
    }
}
using System;
using System.Collections.Generic;

namespace CityEventsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {


           
            

            // У Main() створіть кілька подій
            // додайте у список базового типу CityEvent,
            List<CityEvent> events = new List<CityEvent>
            {
                new Concert("1", "Рок-концерт", 2.5, "The Hard Band"),
                new Exhibition("2", "Виставка сучасного мистецтва", 4, "Міська галерея"),
                new Concert("3", "Джазовий вечір", 3.5, "Jazz Group"),
                new Exhibition("4", "Історична експозиція", 2, "Музей міста")
            };

            double totalDuration = 0;
            int longEventsCount = 0;

            Console.WriteLine("Список подій:\n");

            // виведіть інформацію
            foreach (CityEvent cityEvent in events)
            {
                Console.WriteLine(cityEvent.GetInfo());

                totalDuration += cityEvent.Duration;

                if (cityEvent.IsLongEvent())
                    longEventsCount++;
            }
            // підрахуйте сумарну тривалість та кількість “тривалих” подій.
            Console.WriteLine("\nПідсумок:");
            Console.WriteLine($"Загальна кількість створених подій: {CityEvent.EventCount}");
            Console.WriteLine($"Сумарна тривалість: {totalDuration} год.");
            Console.WriteLine($"Кількість тривалих подій: {longEventsCount}");
        }
    }
}
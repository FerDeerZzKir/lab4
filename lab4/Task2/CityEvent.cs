using System;

namespace CityEventsApp
{
    // Створіть базовий клас CityEvent
    public class CityEvent
    {
        // Кожна подія має унікальний код, назву та тривалість (години)
        // Код, назва і тривалість зберігайте у закритих полях(private)
        // код зробіть незмінним (readonly)
        private readonly string code;
        private string title;
        private double duration;

        // Потрібно знати загальну кількість створених подій
        // лічильник подій — спільним (static)
        private static int eventCount = 0;

        public CityEvent(string code, string title, double duration)
        {
            this.code = code;
            this.title = title;
            this.duration = duration;
            eventCount++;
        }

        public string Code
        {
            get { return code; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public double Duration
        {
            get { return duration; }
            set
            {
                if (value >= 0)
                    duration = value;
            }
        }

        public static int EventCount
        {
            get { return eventCount; }
        }

        // Створіть віртуальний метод (virtual) GetInfo()
        public virtual string GetInfo()
        {
            return $"Код: {code}, Назва: {title}, Тривалість: {duration} год.";
        }

        // та метод, що визначає, чи подія “тривала” (наприклад, більше 3 годин)
        public bool IsLongEvent()
        {
            return duration > 3;
        }
    }
}
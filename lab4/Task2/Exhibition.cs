namespace CityEventsApp
{
    public class Exhibition : CityEvent
    {
        // Exhibition — локація, і перевизначте GetInfo() (override)
        private string location;

        public Exhibition(string code, string title, double duration, string location): base(code, title, duration)
        {
            this.location = location;
        }

        public string Location
        {
            get { return location; }
            set { location = value; }
        }

        public override string GetInfo()
        {
            return $"{base.GetInfo()}, Локація: {location}";
        }
    }
}
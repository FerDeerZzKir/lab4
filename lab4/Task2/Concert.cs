namespace CityEventsApp
{
    public class Concert : CityEvent
    {
        // у Concert додайте поле виконавець
        private string performer;

        public Concert(string code, string title, double duration, string performer): base(code, title, duration)
        {
            this.performer = performer;
        }

        public string Performer
        {
            get { return performer; }
            set { performer = value; }
        }

        public override string GetInfo()
        {
            return $"{base.GetInfo()}, Виконавець: {performer}";
        }
    }
}
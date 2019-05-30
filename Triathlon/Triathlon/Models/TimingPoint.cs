namespace Triathlon.Models
{
    public enum TimingType
    {
        Start,
        SwimEnd,
        BikeStart,
        BikeEnd,
        RunStart,
        End,
        Intermediate
    }

    public class TimingPoint
    {
        public int ID { get; set; }
        public int RaceID { get; set; }
        public string Name { get; set; }
        public TimingType Type { get; set; }
        public Race Race { get; set; }
    }
}

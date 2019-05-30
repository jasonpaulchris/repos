using System;
using System.Collections.Generic;

namespace Triathlon.Models
{
    public class Race
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public DateTime Date { get; set; }

        public ICollection<TimingPoint> TimingPoints { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SoccerScheduler.Elements
{
    [Serializable()]
    class PlayDay : Element
    {
        public DayOfWeek Day { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SoccerScheduler.Elements
{
    [Serializable]
    class Team : Element
    {
        public Category Category { get; set; }
        public string Name { get; set; }
        public PlayDay Day { get; set; }

    }
}

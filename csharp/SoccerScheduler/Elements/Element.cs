using System;
using System.Collections.Generic;
using System.Text;

namespace SoccerScheduler.Elements
{
    [Serializable()]
    abstract class Element
    {

        public Element Instance
        {
            get
            {
                return this;
            }
        }
    }
}

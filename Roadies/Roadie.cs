using System;
using Instruments;

namespace Roadies
{
    public class Roadie
    {
        public void MaintainInstruments(params object[] instruments)
        {
            foreach(var instrument in instruments)
            {
                if (instrument is Guitar)
                    ((Guitar)instrument).PerformMaintenance();
                else if (instrument is SnareDrum)
                    ((SnareDrum)instrument).PerformMaintenance();
            }
        }
    }
}

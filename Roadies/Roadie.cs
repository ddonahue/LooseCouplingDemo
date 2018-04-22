using System;
using Instruments;

namespace Roadies
{
    public class Roadie
    {
        public void MaintainInstruments(params IMaintainable[] instruments)
        {
            foreach(var instrument in instruments)
            {
                instrument.PerformMaintenance();
            }
        }
    }
}

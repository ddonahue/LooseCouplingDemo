using System;
using Instruments;

namespace Roadies
{
    public class Roadie
    {
        public void MaintainInstruments(params IInstrument[] instruments)
        {
            foreach(var instrument in instruments)
            {
                instrument.PerformMaintenance();
            }
        }
    }
}

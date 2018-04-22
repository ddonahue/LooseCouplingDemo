using System;
using Instruments;

namespace Band
{
    public class RockBand
    {
        public void PlaySong(params IInstrument[] instruments)
        {
            foreach(var instrument in instruments)
            {
                instrument.PlaySong();
            }
        }
    }
}

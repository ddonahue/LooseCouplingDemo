using System;
using Instruments;

namespace Band
{
    public class RockBand
    {
        public void PlaySong(params IPlayable[] instruments)
        {
            foreach(var instrument in instruments)
            {
                instrument.PlaySong();
            }
        }
    }
}

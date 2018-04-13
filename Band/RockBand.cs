using System;
using Instruments;

namespace Band
{
    public class RockBand
    {
        public void PlaySong(params object[] instruments)
        {
            foreach(var instrument in instruments)
            {
                if (instrument is Guitar)
                    ((Guitar)instrument).PlaySong();
                else if (instrument is SnareDrum)
                    ((SnareDrum)instrument).PlaySong();
            }
        }
    }
}

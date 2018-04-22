using System;

namespace Instruments
{
    public class SnareDrum : IInstrument
    {
        private bool hasNewDrumHead;

        public void PlaySong()
        {
            if (hasNewDrumHead)
                Console.WriteLine("Crisp sounding snare hit");
            else
                Console.WriteLine("Dull sounding snare hitss");
        }
        
        public void PerformMaintenance()
        {
            hasNewDrumHead = true;
            Console.WriteLine("Snare drum head replaced");
        }
    }
}

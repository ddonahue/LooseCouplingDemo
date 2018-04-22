using System;

namespace Instruments
{
    public class Guitar : IInstrument
    {
        private GuitarStrings guitarStrings;

        public Guitar()
        {
            guitarStrings = new GuitarStrings();
        }

        public void PlaySong()
        {
            guitarStrings.Strum();
        }

        public void PerformMaintenance()
        {
            guitarStrings.Replace();
            Console.WriteLine("Guitar strings changed");
        }
    }
}

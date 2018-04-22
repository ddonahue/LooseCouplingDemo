﻿using System;
using Band;
using Roadies;

namespace Instruments
{
    public class Guitar : IMaintainable, IPlayable
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

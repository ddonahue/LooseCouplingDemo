using System;
using Band;
using Instruments;
using Roadies;

namespace LooseCouplingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var guitar = new Guitar();
            var snareDrum = new SnareDrum();

            var roadie = new Roadie();
            var band = new RockBand();

            roadie.MaintainInstruments(guitar, snareDrum);
            band.PlaySong(guitar, snareDrum);
            band.PlaySong(guitar, snareDrum);
        }
    }
}

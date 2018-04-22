using System;
using Band;
using Guitar;
using SnareDrum;
using Roadies;

namespace LooseCouplingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var guitar = new Guitar.Guitar();
            var snareDrum = new SnareDrum.SnareDrum();

            var roadie = new Roadie();
            var band = new RockBand();

            roadie.MaintainInstruments(guitar, snareDrum);
            band.PlaySong(guitar, snareDrum);
            band.PlaySong(guitar, snareDrum);
        }
    }
}

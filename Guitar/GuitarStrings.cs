using System;

namespace Guitar
{
    public class GuitarStrings
    {
        private bool areNew;

        public GuitarStrings()
        {
            areNew = false;
        }

        public void Replace()
        {
            areNew = true;
        }

        public void Strum()
        {
            if (areNew)
                Console.WriteLine("Crisp sounding guitar strum");
            else
                Console.WriteLine("Dull sounding guitar strum");

            WearOut();
        }

        private void WearOut()
        {
            areNew = false;
        }
    }
}

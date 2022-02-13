using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {

            Distance distance = new Distance();
            distance.ShowText();
            distance.CountSimple(ref distance.start, distance.finsh);

        }
    }
}

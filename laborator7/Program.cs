using System;

namespace laborator7
{
    class Program
    {
        static void Main(string[] args)
        {
            Motor m1 = new Motor(1900, 76, "gpl");
            Autoturism autoturism = new Autoturism("bmw", "x3", 2001, m1, 5);
            Autoturism autoturism2 = new Autoturism("dacia", "logan", 2021, new Motor(1600,130,"benzina"),4);
            Autoturism autoturism3 = new Autoturism("opel", "astra", 1900, new Motor(1500, 50, "motorina"),3);

            autoturism.Porneste();
            autoturism.Opreste();

            Console.WriteLine(autoturism.Description);
            Console.WriteLine(autoturism2.Description);
            Console.WriteLine(autoturism3.Description);

            Console.WriteLine(Autoturism.nrTotalAutoturisme);

            if (Autoturism.bolidul != null)
            {
                Console.WriteLine(Autoturism.bolidul.Description);
            }
        }
    }
}

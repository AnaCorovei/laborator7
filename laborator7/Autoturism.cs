using System;
using System.Collections.Generic;
using System.Text;

namespace laborator7
{
    class Autoturism
    {
        #region static stuff

        private static void InregistreazaAutoturism(Autoturism autoturism)
        {
            nrTotalAutoturisme++;
            if (bolidul == null || autoturism.motor.Putere > bolidul.motor.Putere)
            {
                bolidul = autoturism;
            }
        }

        public static int nrTotalAutoturisme { get; private set; }

        public static Autoturism bolidul { get; private set; }


        #endregion static stuff

        private readonly string marca;
        private readonly string model;
        private readonly int anFabricatie;
        private readonly Motor motor;
        private Usa[] usi;     //definim un vector de usi pentru a afla nr de usi

        public Autoturism(string marca, string model, int anFabricatie, Motor motor, int nrUsi)
        {
            this.marca = marca;
            this.model = model;
            this.anFabricatie = anFabricatie;
            this.motor = motor;

            usi = new Usa[nrUsi];
            for (var i = 0; i < nrUsi; i++)
            {
                usi[i] = new Usa();
            }
            InregistreazaAutoturism(this);
        }

        public void Porneste()
        {
            Console.WriteLine("Masina porneste");
            foreach (Usa usa in usi)
            {
                usa.Inchide();
            }
            motor.Porneste();
            Console.WriteLine("Masina a pornit");
        }
        public void Opreste()
        {
            Console.WriteLine("Masina opreste");
            motor.Opreste();
            foreach (Usa usa in usi)
            {
                usa.Deschide();
            }

            Console.WriteLine("Masina a oprit");
        }

        public string Description
        {
            get
            {
                return $"{marca} {model} {anFabricatie}, {usi.Length}, " +
                  $"{motor.CapacitateCilindrica}, {motor.Putere}, {motor.TipCombustibil}";

            }
        }
    }
}

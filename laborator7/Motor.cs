﻿using System;
using System.Collections.Generic;
using System.Text;

namespace laborator7
{
    class Motor
    {

        private readonly int capacitateCilindrica;
        private readonly int putere;
        private readonly string tipCombustibil;

        public Motor( int capacitateCilindrica, int putere, string tipCombustibil)
        {
            this.capacitateCilindrica = capacitateCilindrica;
            this.putere = putere;
            this.tipCombustibil = tipCombustibil;       
        }

        public int CapacitateCilindrica { get { return capacitateCilindrica; }}
        public int Putere { get { return putere; } }
        public string TipCombustibil { get { return tipCombustibil; } }

        public void Porneste()
        {
            Console.WriteLine("bar bar bar");
        }
        public void Opreste()
        {
            Console.WriteLine("par pac poc");
        }

    }
}

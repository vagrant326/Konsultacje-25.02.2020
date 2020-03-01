using System;
using System.Collections.Generic;
using System.Text;

namespace Konsultacje2
{
    public class Ekspres : IKawa
    {
        private int iloscFilizanek = 0;
        public void Zaparz(string nazwa)
        {
            if (iloscFilizanek>10)
            {
                Console.WriteLine("Wymagane czysczenie");
            }
            else
            {
                Console.WriteLine("Parze");
                iloscFilizanek++;
            }
        }

        public void Czysc()
        {
            iloscFilizanek = 0;
        }
    }
}

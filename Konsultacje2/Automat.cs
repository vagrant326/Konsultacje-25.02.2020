using System;
using System.Collections.Generic;
using System.Text;

namespace Konsultacje2
{
    public class Automat : IKawa
    {
        private double _kredyty = 0;
        public void Zaparz(string nazwa)
        {
            if (_kredyty > 3)
            {
                Console.WriteLine("Parze");
                _kredyty = 0;
            }
            else
            {
                Console.WriteLine("Wrzuc 3zł");
            }
        }

        public void WrzucMonete(double moneta)
        {
            _kredyty += moneta;
        }
    }
}

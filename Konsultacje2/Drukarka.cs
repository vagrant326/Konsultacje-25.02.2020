using System;
using System.Collections.Generic;
using System.Text;

namespace Konsultacje2
{
    [Flags]
    public enum Stan //[000000]
    {
        Dziala = 0,               
        BrakPapieru = 1,            //[100000]
        BrakCzarnegoTuszu = 2,      //[010000]
        BrakRozowegoTuszu = 4,      //[001000]
        BrakZoltegoTuszu = 8,       //[000100]
        BrakNiebieskiegoTuszu = 16,  //[000010]
        Zaciety = 32                 //[000001]
    }
    public class Drukarka
    {
        public Stan stan;
        public void Drukuj(string tekst)
        {
            if (stan.HasFlag(Stan.Dziala))
            {
                Console.WriteLine("Drukuje");
                stan = Stan.BrakZoltegoTuszu;
                stan |= Stan.BrakRozowegoTuszu;
            }
        }
    }
}

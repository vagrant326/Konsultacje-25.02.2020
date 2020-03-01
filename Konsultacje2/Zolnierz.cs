using System;
using System.Collections.Generic;
using System.Text;
//Stwórz klasę Zolnierz. 
//Dodaj do niej właściwości liczbowe 
//Zycie, Doswiadczenie, WymaganeDoswiadczenie i Poziom. 
//Dodaj domyślny konstruktor, który ustawi Zycie=10, 
//Doswiadczenie=0 i Poziom=1. 
//Zabezpiecz pola - Zycie nie 
//może być mniejsze od 0; Poziom można tylko odczytywać; 
//MaxDoswiadczenie nie może być nadpisane i jest generowane 
//ze wzoru MaxDoswiadczenie=100*Poziom; jeśli Doswiadczenie 
//będzie większe niż MaxDoswiadczenie, ustaw Doswiadczenie 
//na 0 i zwiększ Poziom o 1.
namespace Konsultacje2
{
    public class Zolnierz
    {
        private int _zycie;
        public int Zycie {
            get { return _zycie; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Wartość niepoprawna");
                }
                _zycie = value;
            }
        }
        public int Doswiadczenie { get; set; }
        public int WymaganeDoswiadczenie { 
            get 
            {
                return 100 * Poziom;
            }
        }
        public int Poziom { get; }
        public Zolnierz()
        {
            Zycie = 10;
            Doswiadczenie = 0;
            Poziom = 1;
        }
    }
}

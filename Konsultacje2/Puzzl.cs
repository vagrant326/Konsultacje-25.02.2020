using System;
using System.Collections.Generic;
using System.Text;

//Stwórz klasę Puzzle z właściwościami Nazwa, IloscElementow,
//Wiek, Cena. Dodaj pełny konstruktor. Zabezpiecz dane. 
//Nazwa może być zawsze odczytana ale może być zapisana 
//tylko raz. Ilość elementów może być równa tylko 100, 500, 
//1000, 1500 lub 2000. Wiek musi być większy od zera i 
//mniejszy niż 100. Cena nie może być ujemna, zaokrąglij ją 
//do dwóch miejsc po przecinku. Jeśli nowa informacja nie 
//spełnia warunku, wypisz komunikat i jej nie nadpisuj.
namespace Konsultacje2
{
    public class Puzzle
    {
        public Puzzle(
            string nazwa,
            int iloscElementow,
            int wiek,
            double cena)
        {
            Nazwa = nazwa;
            IloscElementow = iloscElementow;
            Wiek = wiek;
            Cena = cena;
        }

        public readonly string Nazwa;
        private int _iloscElementow;
        public int IloscElementow {
            get { return _iloscElementow; }
            set 
            {
                if (value == 100 || value == 500 || value == 1000
                    || value == 1500 || value == 2000)
                {
                    _iloscElementow = value;
                }
                else
                {
                    Console.WriteLine("Bledna ilosc puzzli");
                }
            } 
        }
        private int _wiek;
        public int Wiek { get { return _wiek; } 
            set 
            {
                if (value > 0 && value < 100)
                {
                    _wiek = value;
                }
                else
                {
                    Console.WriteLine("Wiek jest błędny");
                }
            } 
        }

        private double _cena;
        public double Cena 
        { 
            get { return _cena; }
            set 
            {
                if (value>0)
                {
                    var temp = value * 100;
                    var temp2b = Convert.ToInt32(temp);
                    var wynik = temp2b / 100.0;
                }
                else
                {
                    Console.WriteLine("Cena nie może być mniejsza niż zero.");
                }
            }
        }

    }
}

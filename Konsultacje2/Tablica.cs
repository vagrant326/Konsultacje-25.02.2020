using System;
using System.Collections.Generic;
using System.Text;

namespace Konsultacje2
{
    //Stwórz dwuwymiarową tablicę prostokątną i wypełnij 
    //wszystkie komórki cyfrą 1. Do jednej z komórek 
    //wpisz ręcznie wartość, np. 104. Napisz funkcję, 
    //która obliczy średnią wartość w tabeli i wypisze ją 
    //na konsoli.
    public class Tablica
    {
        public void Srednia()
        {
            int[,] tab = new int[3, 3]
            {
                {1, 1, 1},
                {1, 1, 1},
                {1, 1, 1}
            };

            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    tab[i, j] = 1;
                }
            }
            tab[1, 1] = 104;
            var suma = 0;

            //suma = // źle
            //    tab[0, 0] + tab[0, 1] + tab[0, 2] +
            //    tab[1, 0] + tab[1, 1] + tab[1, 2] +
            //    tab[2, 0] + tab[2, 1] + tab[2, 2];

            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    suma += tab[i, j];
                }
            }

            var wynik = (double)suma / tab.Length;
            Console.WriteLine(wynik);
        }
    }
}

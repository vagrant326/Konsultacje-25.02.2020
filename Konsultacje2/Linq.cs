using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Konsultacje2
{
    public class Linq
    {
        public void Daty()
        {
            List<DateTime> lista = new List<DateTime>()
            {
                DateTime.Today,
                new DateTime(2020,2,1),
                new DateTime(1920,2,1),
                new DateTime(2019,2,1),
                new DateTime(2020,2,24)
            };
            // year
            // month  
            // day      >select year>  year
            // hour 
            // minutes
            //



            var posortowanaKolekcja = lista.OrderByDescending(x => x).ToList();
            var piatki = lista.Where(x => x.DayOfWeek == DayOfWeek.Friday).Count();
            var sredniRok = lista.Select(x => new Point(x.Year, x.Month));
            foreach (var item in posortowanaKolekcja)
            {
                Console.WriteLine(item.ToShortDateString());
            }
            Console.WriteLine(piatki);
            Console.WriteLine(sredniRok);
        }
    }
}

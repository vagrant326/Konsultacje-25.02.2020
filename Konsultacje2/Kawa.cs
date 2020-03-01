using System;
using System.Collections.Generic;
using System.Text;

namespace Konsultacje2
{
    public class Kawa
    {
        public void Test()
        {
            List<IKawa> zaparzacze = new List<IKawa>
            {
                new Ekspres(),
                new Automat()
            };
            for (int i = 0; i < 20; i++)
            {
                foreach (var item in zaparzacze)
                {
                    item.Zaparz("Latte");
                }
            }
        }
    }
}

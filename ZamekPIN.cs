using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokiwum_2
{
    class ZamekPIN : IZamek
    {
        int Pin;
        bool stan;

        public ZamekPIN(int pin)
        {
            Pin = pin;
        }

        public void Otworz()
        {
            int pin1;
            Console.WriteLine("Podaj 4 cyfrowy PIN");
            pin1 = int.Parse(Console.ReadLine());

            if (Pin == pin1)
            {
                Console.WriteLine("Pin wlasciwy ZALOGOWANO");
                stan = true;
            }
            else
            {
                Console.WriteLine("Zly PIN");
                stan = false;
            }
        }

        public void Zamknij()
        {
            if (stan == false)
            {
                Console.WriteLine("Blad aplikacja juz jest zamknieta!!!");
            }
        }
    }
}

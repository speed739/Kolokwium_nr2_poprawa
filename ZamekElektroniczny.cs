using System;
using System.Collections.Generic;
using System.Text;


namespace Kolokiwum_2
{
    class ZamekElektroniczny : IZamek
    {

        DateTime logowanie;
        DateTime wylogowanie;
        List<DateTime> lista_log = new List<DateTime>();
        List<DateTime> lista_wylog = new List<DateTime>();
        bool stan = false;

        public void Otworz()
        {
            Console.WriteLine("Przyloz karte");
            logowanie = DateTime.Now;
            lista_log.Add(logowanie);
            stan = true;

        }

        public void Zamknij()
        {
            if(stan == true)
            {
                Console.WriteLine("Wylogowano");
                wylogowanie = DateTime.Now;
                lista_wylog.Add(wylogowanie);
            }
            else
            {
                Console.WriteLine("Blad aplikacja juz jest zamknieta!!!");

            }
            
        }
    }
}

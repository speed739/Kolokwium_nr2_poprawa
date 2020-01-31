using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Kolokiwum_2
{
    class Mieszkanie
    {
        int metraz;
        int odleglosc_od_centrum;
        string nazwa;

        public Mieszkanie(int odleglosc_od_centrum, string nazwa)
        {

            this.odleglosc_od_centrum = odleglosc_od_centrum;
            this.nazwa = nazwa;
        }

        public void Generuj_metraz(List<Mieszkanie> list)
        {
            Random x = new Random();
            list.ForEach(a =>
            {
                a.metraz = x.Next(0, 50);

            });


        }

        public void Filtruj(List<Mieszkanie> lista, int min, int max, int odleglosc)
        {
            List<Mieszkanie> lista_wynikowa = new List<Mieszkanie>();


            lista.ForEach(x =>
            {
                if (x.metraz >= min && x.metraz <= max)
                {
                    lista_wynikowa = lista;

                }

            });
            lista_wynikowa.ForEach(y =>
            {
                if (y.odleglosc_od_centrum < odleglosc)
                {
                    Console.WriteLine("Nazwa mieszkania - " + y.nazwa);

                }

            });
        }
    }
}


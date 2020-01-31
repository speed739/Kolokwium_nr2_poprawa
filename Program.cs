using System;
using System.Drawing;
using System.Collections.Generic;

namespace Kolokiwum_2
{
    interface IZamek
    {
        void Otworz();
        void Zamknij();

    }


    class Program
    {
        static void Main(string[] args)
        {

            Test test = new Test(1234, "TEST", "kolowkium", true);
            var (x, y) = test;
            Console.WriteLine($"Id - {x} Powodzenie - {y}");
            var (a, b, c, d) = test;
            Console.WriteLine($"Id - {a} Powodzenie - {d} opis {c} nazwa - {b}");

            ZamekPIN xyz = new ZamekPIN(1234);
            ZamekElektroniczny asd = new ZamekElektroniczny();
            List<IZamek> lista_zamkow = new List<IZamek>() { xyz,asd};
            lista_zamkow.ForEach(xy => 
            {
                xy.Otworz();
                xy.Zamknij();
            });
            Point abcd = new Point(-1, 2);
            abcd.Extension_method();



        }
    }
}

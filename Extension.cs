using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Kolokiwum_2
{
    public static class Extension
    {
        public static void Extension_method(this Point a)
        {
            if (a.X > 0 && a.Y > 0)
            {
                Console.WriteLine("Cwiartka ukladu wsp nr 1");

            }
            if (a.X > 0 && a.Y < 0)
            {
                Console.WriteLine("Cwiartka ukladu wsp nr 2");

            }
            if (a.X < 0 && a.Y > 0)
            {
                Console.WriteLine("Cwiartka ukladu wsp nr 3");

            }
            if (a.X < 0 && a.Y < 0)
            {
                Console.WriteLine("Cwiartka ukladu wsp nr 4");

            }
            if(a.X ==0 && a.Y ==0)
            {
                Console.WriteLine("Srodek ukladu");
            }

        }

    }



}

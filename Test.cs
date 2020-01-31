using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokiwum_2
{
    class Test
    {
        int id;
        string nazwa, opis;
        bool powodzenie;

        public Test(int id, string nazwa, string opis, bool powodzenie)
        {
            this.id = id;
            this.nazwa = nazwa;
            this.opis = opis;
            this.powodzenie = powodzenie;
        }
        public void Deconstruct(out int id,out bool powodzenie)
        {
            id = this.id;
            powodzenie = this.powodzenie;

        }
        public void Deconstruct(out int id,out string nazwa,out string opis,out bool powodzenie)
        {
            id = this.id;
            powodzenie = this.powodzenie;
            opis = this.opis;
            nazwa = this.nazwa;
            powodzenie = this.powodzenie;

        }

    }
}

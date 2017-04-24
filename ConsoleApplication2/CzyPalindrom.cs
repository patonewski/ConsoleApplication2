using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class CzyPalindrom
    { public CzyPalindrom()
        { }
        public CzyPalindrom(int x)
        {
            int wynik = x;
        }

        public bool SprawdzPoprawnosc(int wynik)
        {
            string tekst = Convert.ToString(wynik);
            int dlugosc = tekst.Length - 1;
            bool palindrom = true;
            for (int x = 0; x <= 2; x++)

            {
                if (tekst[x] == tekst[dlugosc])
                {
                    dlugosc--;
                }
                else
                { palindrom = false; }

            }
            return palindrom;
        }
    }

}


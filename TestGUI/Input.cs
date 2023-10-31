using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGUI
{
    internal class Input : Interface1
    {
        List<int> kode = new List<int>();
        public static string kombo = "4";

        public bool Godkjenning(string user)
        {
            bool svar = false;
            if (svar == false)
            {
                kombo = kode[0].ToString() + kode[1].ToString() + kode[2].ToString() + kode[3].ToString();
                svar = true;
            }
            else
            {
                MessageBox.Show("Feil kode, skriv inn på nytt");
                kode.Clear();
            }
            return svar;
        }

        public List<int> Kode()
        {
            return kode;
        }
        public string Kombo()
        {
            return kombo;
        }
    }
}

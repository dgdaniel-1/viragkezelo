using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viragrendeles_kezelo
{
    class Virag
    {
        string nev;
        int ar;

        public string Nev 
        {
            get => nev;
            set
            {
                nev = !string.IsNullOrEmpty(value) ? value : "Hibas!";
            }
        }
        public int Ar 
        { 
            get => ar;
            set
            {
                ar = !string.IsNullOrEmpty(value.ToString()) ? value : 1;
            } 
        }
        public Virag(string nev, int ar)
        {
            Nev = nev;
            Ar = ar;
        }
        public int Rendelesar(int darab)
        {
            return darab * this.Ar;
        }
        public static string CSVFormatum(Virag virag)
        {
            return $"{virag.Nev}; {virag.Ar}\n";
        }
        public override string ToString()
        {
            return $"{nev}, {ar}";
        }
    }
}

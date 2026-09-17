using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DiakToString
{
    internal class Diak
    {
        public string Nev { get; set; }
        public double Atlag { get; set; }
        public Diak()
        {
            Nev = "Nagy László Benedek";
            Atlag = 4.5;
        }
        public Diak(string kapottnev, double kapottatlag)
        {
            Nev = kapottnev;
            Atlag = kapottatlag;
        }
        public Diak(string csaknev)
        {
            Nev = csaknev;
            Atlag = 4.3;
        }
        public override string ToString()
        {
            return $"Nev: {Nev}, Atlag {Atlag}";
        }
    }
}

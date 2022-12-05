using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_XML_dokumenti
{
    internal class osoba
    {
        string ime, prezime;
        int godRod;

    

        public osoba(string ime, string prezime, int godRod)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.GodRod = godRod;

        }

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public int GodRod { get => godRod; set => godRod = value; }

        public override string ToString()
        {
            return "Ime: " + Ime + "\r\nPrezime: " + Prezime + "\r\nGodina rođenja: " + GodRod;
        }
    }

    

}

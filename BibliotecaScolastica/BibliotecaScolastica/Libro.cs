using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaScolastica
{
    internal class Libro
    {
        public string Titolo { get; set; }
        public string Autore { get; set; }
        public int AnnoPubblicazione { get; set; }
        public string Editore { get; set; }
        public int NumeroPagine { get; set; }
        public Libro(string titolo, string autore, string isbn, int annoPubblicazione)
        {
            Titolo = titolo;
            Autore = autore;
            AnnoPubblicazione = annoPubblicazione;
        }
        public override string ToString()
        {
            return $"{Titolo} di {Autore}, pubblicato nel {AnnoPubblicazione}";
        }
        public void ReadingTime(int numPag)
        {
            numPag = NumeroPagine;
            if (numPag <= 100)
            {
                Console.WriteLine("Hai letto per 1 ora");
                return;
            }
            else if (numPag > 100 && numPag <= 200)
            {
                Console.WriteLine("Hai letto per 2 ore");
                return;
            }
            else if (numPag > 200)
            {
                Console.WriteLine("Hai letto per più di 2 ore");
                return;
            }
        }
    }
}

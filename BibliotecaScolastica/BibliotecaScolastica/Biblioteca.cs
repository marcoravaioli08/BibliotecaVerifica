using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaScolastica
{
    internal class Biblioteca
    {
        public string NomeBiblioteca { get; set; }
        public string Indirizzo { get; set; }
        public int OrarioApertura { get; set; }
        public int OrarioChiusura { get; set; }
        public List<Libro> ElencoLibri { get; set; }
        public Biblioteca(string nomeBiblioteca, string indirizzo, int orarioApertura, int orarioChiusura)
        {
            NomeBiblioteca = nomeBiblioteca;
            Indirizzo = indirizzo;
            OrarioApertura = orarioApertura;
            OrarioChiusura = orarioChiusura;
            ElencoLibri = new List<Libro>();
        }
        public void AggiungiLibro(Libro libro)
        {
            ElencoLibri.Add(libro);
        }
        public void TrovaLibroPerTitolo(string titolo)
        {
            var libroTrovato = ElencoLibri.FirstOrDefault(l => l.Titolo.Equals(titolo, StringComparison.OrdinalIgnoreCase));
        }
        public void TrovaLibroPerAutore(string autore)
        {
            var libriTrovati = ElencoLibri.Where(l => l.Autore.Equals(autore, StringComparison.OrdinalIgnoreCase)).ToList();
        }
        public void NumeroTotaleLibri()
        {
            int totaleLibri = ElencoLibri.Count;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaScolastica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Benvenuto nella Biblioteca Scolastica!");
            Console.WriteLine("Dimmi il nome della biblioteca");
            string NomeBiblioteca = Console.ReadLine();
            Console.WriteLine("Dimmi l'indirizzo della biblioteca");
            string Indirizzo = Console.ReadLine();
            Console.WriteLine("Dimmi Gli orari d'apertura e poi chiusura della biblioteca");
            string OraroApertura = Console.ReadLine();
            string OrarioChiusura = Console.ReadLine();   
            Biblioteca biblioteca = new Biblioteca(NomeBiblioteca, Indirizzo, OraroApertura, OrarioChiusura);
            Console.WriteLine("La biblioteca " + biblioteca.NomeBiblioteca + " si trova in " + biblioteca.Indirizzo + " ed è aperta dalle " + biblioteca.OraroApertura + " alle " + biblioteca.OrarioChiusura);
            Console.WriteLine("Vuoi aggiungere un libro alla biblioteca? (sì/no)");
            string risposta = Console.ReadLine();
            if (risposta.ToLower() == "sì")
            {
                Console.WriteLine("Dimmi il titolo del libro");
                string Titolo = Console.ReadLine();
                Console.WriteLine("Dimmi l'autore del libro");
                string Autore = Console.ReadLine();
                Console.WriteLine("Dimmi l'anno di pubblicazione del libro");
                int AnnoPubblicazione = int.Parse(Console.ReadLine());
                Console.WriteLine("Dimmi l'editore del libro");
                string Editore = int.Parse(Console.ReadLine());
                Console.WriteLine("Dimmi il numero di pagine");
                int NumeroPagine = int.Parse(Console.ReadLine());
                Libro libro = new Libro(Titolo, Autore, AnnoPubblicazione, Editore, NumeroPagine);
                biblioteca.AggiungiLibro(libro);
                Console.WriteLine("Libro aggiunto con successo!");
                Console.WriteLine("La biblioteca ora contiene " + biblioteca.Libri.Count + " libri.");
                if (biblioteca.Libri.Count > 0)
                {
                    Console.WriteLine("Vuoi Trovare un libro per titolo? (sì/no)");
                    string rispostaTrova = Console.ReadLine();
                    if (rispostaTrova.ToLower() == "sì")
                    {
                        Console.WriteLine("Dimmi il titolo del libro da trovare");
                        string titoloDaTrovare = Console.ReadLine();
                        Libro libroTrovato = biblioteca.TrovaLibroPerTitolo(titoloDaTrovare);
                        if (libroTrovato != null)
                        {
                            Console.WriteLine("Libro trovato: " + libroTrovato.Titolo + " di " + libroTrovato.Autore);
                        }
                        else
                        {
                            Console.WriteLine("Libro non trovato.");
                        }
                    }
                    Console.WriteLine("Vuoi Trovare tutti i libri di un autore? (sì/no)");
                    string rispostaTrovaAutore = Console.ReadLine();
                    if (rispostaTrovaAutore.ToLower() == "sì")
                    {
                        Console.WriteLine("Dimmi l'autore dei libri da trovare");
                        string autoreDaTrovare = Console.ReadLine();
                        List<Libro> libriTrovati = biblioteca.TrovaLibriPerAutore(autoreDaTrovare);
                        if (libriTrovati.Count > 0)
                        {
                            Console.WriteLine("Libri trovati di " + autoreDaTrovare + ":");
                            foreach (Libro libro in libriTrovati)
                            {
                                Console.WriteLine("- " + libro.Titolo);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Nessun libro trovato per l'autore " + autoreDaTrovare);
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Nessun libro aggiunto.");
            }
        }
}

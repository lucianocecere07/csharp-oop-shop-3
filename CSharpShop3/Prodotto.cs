using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShop3
{
    public class Prodotto
    {
        //proprietà
        private int codice;
        private string nome;
        private string descrizione;
        private double prezzo;
        private int iva;
        
        //contare il numero di prodotti presenti
        private static int numeroProdottiPresenti = 0;

        //costruttori
        public Prodotto(int codice, string nome, string descrizione, double prezzo, int iva)
        {
            this.codice = CalcoloCodice();
            this.nome = nome;
            this.descrizione = descrizione;
            this.prezzo = prezzo;
            this.iva = iva;
        }

        public Prodotto(string nome, string descrizione, double prezzo, int iva)
        {
            this.codice = CalcoloCodice();
            if(nome == "" || nome == " ")
            {
                throw new ArgumentException("nome", "il nome non può essere vuoto");
            }
            this.nome = nome;
            this.descrizione = descrizione;
            if(prezzo <= 0)
            {
                throw new ArgumentOutOfRangeException("prezzo", "il prezzo non può avere valore inferiore a 0");
            }
            this.prezzo = prezzo;
            if (iva < 0)
            {
                throw new ArgumentOutOfRangeException("iva", "l'iva non può essere negativa");
            }
            this.iva = iva;
            numeroProdottiPresenti++;
        }

        //getter
        public int GetCodice()
        {
            return this.codice;
        }

        public string GetNome()
        {
            return this.nome;
        }

        public string GetDescrizione()
        {
            return this.descrizione;
        }

        public double GetPrezzo()
        {
            return this.prezzo;
        }

        public int GetIva()
        {
            return this.iva;
        }

        public static int GetNumeroProdottiPresenti()
        {
            return numeroProdottiPresenti;
        }

        //setter
        public void SetNome(string nome)
        {
            if (nome == "" || nome == " ")
            {
                throw new ArgumentException("nome", "il nome non può essere vuoto");
            }
            this.nome = nome;
        }

        public void SetDescrizione(string descrizione)
        {
            this.descrizione = descrizione;
        }

        public void SetPrezzo(double prezzo)
        {
            if (prezzo > 0)
            {
                this.prezzo = prezzo;
            }
            else
            {
                throw new ArgumentOutOfRangeException("prezzo", "il prezzo non può avere valore inferiore a 0");
            }
        }

        public void SetIva(int iva)
        {
            if (iva < 0)
            {
                throw new ArgumentOutOfRangeException("iva", "l'iva non può essere negativa");
            }
            this.iva = iva;
        }

        //metodi

        //METODO PRIVATO
        private int CalcoloCodice()
        {
            //generare un numero random da 1 a 100
            Random generatoreNumeriRandom = new Random();
            int numeroRandom = generatoreNumeriRandom.Next(1, 100);
            return numeroRandom;
        }

        public void StampaPrezzo()
        {
            //prezzo con 2 decimali
            Console.WriteLine("Prezzo (senza iva): " + Math.Round(prezzo, 2) + " euro");
            double prezzoTotale = prezzo / 100 * iva + prezzo;
            Console.WriteLine("Prezzo (con iva): " + Math.Round(prezzoTotale, 2) + " euro");
        }

        public void StampaNome()
        {
            Console.WriteLine("Nome completo del prodotto: " + codice + nome);
        }

        public virtual void StampaProdotto()
        {
            Console.WriteLine("------------------");
            Console.WriteLine("nome: " + nome);
            Console.WriteLine("descrizione: " + descrizione);
            Console.WriteLine("Prezzo (senza iva): " + Math.Round(prezzo, 2) + " euro");
            Console.WriteLine("iva: " + iva + "%");
            double prezzoTotale = prezzo / 100 * iva + prezzo;
            Console.WriteLine("Prezzo (con iva): " + Math.Round(prezzoTotale, 2) + " euro");
            StampaNome();
        }
    }
}

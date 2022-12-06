using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShop3
{
    public class Frutta : Prodotto
    {
        //proprietà
        private int pezzi;

        //costruttori
        public Frutta(string nome, string descrizione, double prezzo, int iva, int pezzi) : base(nome, descrizione, prezzo, iva)
        {
            this.pezzi = pezzi;
        }

        //getter
        public int GetPezzi()
        {
            return this.pezzi;
        }

        //setter
        public void SetPezzi(int pezzi)
        {
            if (pezzi <= 5)
            {
                this.pezzi = pezzi;
            }
            else
            {
                Console.WriteLine("i pezzi sono massimo 5");
            }
        }

        //metodi
        public void TogliPezzo(int pezzo)
        {
            if (pezzo > 0 && pezzo < 6)
            {
                this.pezzi -= pezzo;
            }
            else
            {
                Console.WriteLine("non si possono togliere questo numero di pezzi");
            }
        }

        //override
        public override void StampaProdotto()
        {
            base.StampaProdotto();
            Console.WriteLine("pezzi: " + pezzi);
        }
    }
}

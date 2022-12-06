using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShop3
{
    public class Acqua : Prodotto
    {
        //proprietà
        private double litri;
        private double pH;
        private string sorgente;

        //costruttori
        public Acqua(string nome, string descrizione, double prezzo, int iva, double litri, double pH, string sorgente) : base(nome, descrizione, prezzo, iva)
        {
            this.litri = litri;
            this.pH = pH;
            this.sorgente = sorgente;
        }

        //getter
        public double GetLitri()
        {
            return this.litri;
        }

        public double GetPH()
        {
            return this.pH;
        }

        public string GetSorgente()
        {
            return this.sorgente;
        }

        //setter
        public void SetLitri(double litri)
        {
            if (litri < 1.5)
            {
                this.litri = litri;
            }
            else
            {
                Console.WriteLine("la bottiglia può essere massimo di 1,5 litri");
            }
        }

        //metodi
        public void Bevi(double litriDaBere)
        {
            if (litriDaBere < litri)
            {
                this.litri = litri - litriDaBere;
            }
            else
            {
                Console.WriteLine("quanto bevi non può essere superiore ai litri della bottiglia");
            }
        }

        public void Riempi(double litro)
        {
            if (litro < litri)
            {
                this.litri += litro;
            }
            else
            {
                Console.WriteLine("l'acqua non viene inserita, può strabordare");
            }
        }

        public void Svuota()
        {
            this.litri = 0;
        }

        //override
        public override void StampaProdotto()
        {
            base.StampaProdotto();
            Console.WriteLine("litri: " + litri + " l");
            Console.WriteLine("pH: " + pH);
            Console.WriteLine("sorgente: " + sorgente);
        }
    }
}

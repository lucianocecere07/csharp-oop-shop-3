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
        private double maxCapienza;

        //costruttori
        public Acqua(string nome, string descrizione, double prezzo, int iva, double litri, double pH, string sorgente) : base(nome, descrizione, prezzo, iva)
        {
            this.litri = litri;
            this.pH = pH;
            this.sorgente = sorgente;
            this.maxCapienza = 1.5;
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
            if (litri <= maxCapienza)
            {
                this.litri = litri;
            }
            else
            {
                Console.WriteLine("la bottiglia può essere massimo di 1,5 litri");
            }
        }

        //metodi

        public double Bevi(double litriDaBere)
        {
            if (litriDaBere <= this.litri)
            {
                this.litri = this.litri - litriDaBere;
                if (this.litri == 0)
                {
                    Console.WriteLine("Hai finito l'acqua.");
                }
            }
            else
            {
                Console.WriteLine("quanto bevi non può essere superiore ai litri della bottiglia");
            }

            return this.litri;
        }

        public void Riempi(double litro)
        {
            if (litro <= this.maxCapienza - this.litri)
            {
                this.litri += litro;
            }
            else
            {
                Console.WriteLine("l'acqua non viene più inserita, può strabordare");
                this.litri = this.maxCapienza;
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

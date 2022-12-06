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
        private double maxCapienza = 1.5;
        private const double costanteGallone = 3.785;

        //costruttori
        public Acqua(string nome, string descrizione, double prezzo, int iva, double litri, double pH, string sorgente) : base(nome, descrizione, prezzo, iva)
        {
            if(litri > maxCapienza || litri < 0)
            {
                throw new ArgumentOutOfRangeException("litri", "i litri contenuti nella bottiglia sono errati");
            }
            this.litri = litri;
            if(pH < 6.5 || pH > 9.5)
            {
                throw new ArgumentOutOfRangeException("pH", "per l'acqua potabile valori ammissibili di pH tra 6.5 e 9.5 pH");
            }
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
            if (litri > maxCapienza || litri < 0)
            {
                throw new ArgumentOutOfRangeException("litri", "i litri contenuti nella bottiglia sono errati");
            }
            this.litri = litri;
        }

        public void SetPH(double pH)
        {
            if (pH < 6.5 || pH > 9.5)
            {
                throw new ArgumentOutOfRangeException("pH", "per l'acqua potabile valori ammissibili di pH tra 6.5 e 9.5 pH");
            }
            this.pH = pH;
        }

        //metodi

        public double Bevi(double litriDaBere)
        {
            if (litriDaBere <= this.litri)
            {
                this.litri = this.litri - litriDaBere;
                if (this.litri == 0)
                {
                    throw new ArgumentException("la bottiglia è vuota");
                }
            }
            else
            {
                throw new ArgumentOutOfRangeException("quanto bevi non può essere superiore ai litri nella bottiglia");
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
                this.litri = this.maxCapienza;
                throw new ArgumentOutOfRangeException("l'acqua non viene inserita, può strabordare");
            }
        }

        public void Svuota()
        {
            this.litri = 0;
        }

        //metodo statico converte In Galloni
        public static double ConvertiInGalloni(double litri)
        {
            double galloni = Math.Round(litri * costanteGallone, 3);
            return galloni;
        }

        //override
        public override void StampaProdotto()
        {
            base.StampaProdotto();
            Console.WriteLine("litri: " + Math.Round(litri, 2) + " l");
            Console.WriteLine("pH: " + pH);
            Console.WriteLine("sorgente: " + sorgente);
        }
    }
}

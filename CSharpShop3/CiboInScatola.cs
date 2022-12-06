using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShop3
{
    public class CiboInScatola : Prodotto
    {
        //proprietà
        private int grammi;
        private string tipoCibo;
        private string materialeScatola;

        //costruttori
        public CiboInScatola(string nome, string descrizione, double prezzo, int iva, int grammi, string tipoCibo, string materialeScatola) : base(nome, descrizione, prezzo, iva)
        {
            this.grammi = grammi;
            this.tipoCibo = tipoCibo;
            this.materialeScatola = materialeScatola;
        }

        //getter
        public int GetGrammi()
        {
            return this.grammi;
        }

        public string GetTipoCibo()
        {
            return this.tipoCibo;
        }

        public string GetMaterialeScatola()
        {
            return this.materialeScatola;
        }

        //setter
        //metodi
        public void Mangia(int grammiMangiati)
        {
            if (grammiMangiati < grammi)
            {
                this.grammi = grammi - grammiMangiati;
            }
            else
            {
                Console.WriteLine("impossibile mangiare una quantità maggiore rispetto a quanto è presente nella scatola");
            }
        }

        public void Svuota()
        {
            this.grammi = 0;
        }

        //override
        public override void StampaProdotto()
        {
            base.StampaProdotto();
            Console.WriteLine("grammi: " + grammi + " g");
            Console.WriteLine("tipo di cibo: " + tipoCibo);
            Console.WriteLine("materiale della scatola: " + materialeScatola);
        }
    }
}

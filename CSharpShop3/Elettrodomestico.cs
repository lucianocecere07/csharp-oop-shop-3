using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShop3
{
    public class Elettrodomestico : Prodotto
    {
        //proprietà
        private string marca;
        private string materiale;
        private string classeConsumi;

        //costruttori
        public Elettrodomestico(string nome, string descrizione, double prezzo, int iva, string marca, string materiale, string classeConsumi) : base(nome, descrizione, prezzo, iva)
        {
            this.marca = marca;
            this.materiale = materiale;
            this.classeConsumi = classeConsumi;
        }

        //getter
        public string GetMarca()
        {
            return this.marca;
        }

        public string GetMateriale()
        {
            return this.materiale;
        }

        public string GetClasseElettrica()
        {
            return this.classeConsumi;
        }

        //setter

        //metodi

        //override
        public override void StampaProdotto()
        {
            base.StampaProdotto();
            Console.WriteLine("marca: " + marca);
            Console.WriteLine("materiale: " + materiale);
            Console.WriteLine("classeConsumi: " + classeConsumi);
        }
    }
}

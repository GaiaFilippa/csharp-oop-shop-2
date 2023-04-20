using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Shop_2
{
    public class Water : itemShop
    {
        public float liters;
        public float ph;
        public string source;
        public string brand;

        // COSTRUTTORE
        public Water(string name, float  liters, float ph, string source, string brand) : base(name)
        {
            this.liters = liters;
            this.ph = ph;
            this.source = source;
            this.brand = brand;
        }

        // GETTERS
        public float GetLiters()
        {
            return this.liters;
        }

        public float GetPH()
        {
            return this.ph;
        }
        public string GetSource()
        {
            return this.source;
        }

        public string GetBrand()
        {
            return this.brand;
        }

        // SETTERS


        // METODI

        public override void AddValues()
        {
            base.AddValues();
            string Values = "Tot litri: " + this.liters + "l";
            Values += "Livello di acidità dell'acqua: " + this.ph;
            Values += "Sorgente: " + this.source;
            Values += "Marca: " + this.brand;
            
        }

    }
}

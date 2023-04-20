using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Shop_2
{
    public class itemShop 
    {
        protected private string name;
        protected private List<Category> categories;
        

        // COSTRUTTORE

        public itemShop(string name)
        {
            this.name = name;
            this.categories = new List<Category>();
        }



        // GETTERS 

        public string GetName()
        {
            return this.name;
        }

        public List<Category> GetCategoriesList()
        {
            return this.categories;
        }


        public virtual string GetItemString()
        {
            string rapprString = "Nome prodotto: " + this.name + "\n";
            rapprString += "\t Categoria prodotto: \n";
            foreach (Category categoriaScansionata in categories)
            {
                rapprString += "\t - " + categoriaScansionata.GetName() + "\n";
            }

            return rapprString;

        }

        public void addCaetogy(Category newCategory)
        {
            this.categories.Add(newCategory);
        }
    }
}

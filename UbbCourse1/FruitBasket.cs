using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cursuri1_4
{
    class FruitBasket
    {
        public List<Fruit> listaFructe;
        public FruitBasket()
        {
            listaFructe = new List<Fruit>();
        }
        public void addFruit(Fruit fruit)
        {
            listaFructe.Add(fruit);
        }

        public void displayFruitCalories()
        {
            foreach (var f in listaFructe)
            {
                Console.WriteLine(f);
            }
        }
    }

}

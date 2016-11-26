using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cursuri1_4
{
    class Program
    {
        static void Main(string[] args)
        {
           /* Mercedes mercedes = new Mercedes();
            EngineStruct engine = new EngineStruct();
            ICar car = new Mercedes();
            AbstractCar car2 = new Mercedes();

            Console.WriteLine("This is my first C# project!");
            Console.WriteLine("Mercedes is " + mercedes.Description);
            Console.WriteLine("Mercedes costs  " + mercedes.Price);

            Mercedes m1 = new Mercedes();
            m1.PrintMercedesLogo();
            m1.PrintNewMercedes(Mercedes.staticcounter++);
            Mercedes m2 = new Mercedes();
            Mercedes m3 = new Mercedes();
            Mercedes m4 = new Mercedes();
            m2.PrintNewMercedes(Mercedes.staticcounter++);
            m3.PrintNewMercedes(Mercedes.staticcounter++);
            m4.PrintNewMercedes(Mercedes.staticcounter++);

            Mercedes.StartEngine();

            Mercedes nrkm = new Mercedes();
            nrkm.ArataNrKmRamasi(10, 7);

            double NrKmRamasi;
            NrKmRamasi = nrkm.ArataNrKmRamasi(10, 7);
            Console.WriteLine("Numarul de km ramasi: " + NrKmRamasi);

            Mercedes NrMilisec = new Mercedes();
            NrMilisec.StartEngine(12);

            Mercedes AfiseazaConsum = new Mercedes();
            AfiseazaConsum.CalculateConsumption(10);

            double calcConsum;
            calcConsum = AfiseazaConsum.CalculateConsumption(10);
            Console.WriteLine("Consumul masinii este: " + calcConsum);

            Audi a = new Cursuri1_4.Audi();
            a.CarStart();

            a.Vitezometru(1);
            a.Vitezometru(2);
            a.Vitezometru(3);
            a.Vitezometru(0);

            Console.ReadKey();
        */
           /*
            Fruit fruit = new Fruit();
            Console.WriteLine(fruit.getCalories());
            Apple apple = new Apple();
            Console.WriteLine(apple.getCalories());
            Orange orange = new Orange();
            Ionatan ionatan = new Ionatan();
            Console.WriteLine(ionatan.getCalories());
           
            Apple a = new Ionatan();
            Console.WriteLine(a.getCalories());
            Ionatan i = new Ionatan();
            Console.WriteLine(i.getCalories());
            Fruit f = new Ionatan();
            Console.WriteLine(f.getCalories());
            */

            Apple a = new Apple();
            Ionatan i = new Ionatan();
            Fruit f = new Fruit();
            FruitBasket basket = new FruitBasket();
            basket.addFruit(a);
            basket.addFruit(i);
            basket.addFruit(f);
            basket.displayFruitCalories();
            
            Console.ReadKey();
        
        }
    }
}


﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cursuri1_4
{
    public class Mercedes: AbstractCar
    {
        internal string Description;
        internal int Price;
        private string to_description;
        private int and_price;
        public Mercedes()
        {
            to_description = "E Class";
            and_price = 67000;  
        }
        private int counter;

        public void PrintMercedesLogo()
        {
            counter++;
            if (counter == 3) return;
            Console.WriteLine("This is from Mercedes");
            PrintMercedesLogo();
        }

        public void PrintNewMercedes(int c)
        {
            if (c == 3) return;
            Console.WriteLine("Mercedes No = " + c);
        }
        public static int staticcounter;

        public static void StartEngine()
        {
            Console.WriteLine("Engine Started");
        }

        public double ArataNrKmRamasi(double noOfFuelLiters, double Consumption)
        {
            //Console.WriteLine("Remaining km:" + noOfFuelLiters / Consumption * 100);
            double result = 0;
            result = noOfFuelLiters / Consumption * 100;
            return result;
        }
        public double CalculateConsumption(params int[] kms)
        {
            double sum = 0;
            foreach (int km in kms)
                sum += km;
            return sum / 100 * 7;
        }

        internal void StartEngine(int v)
        {
            Console.WriteLine(" ");
        }
    }
}

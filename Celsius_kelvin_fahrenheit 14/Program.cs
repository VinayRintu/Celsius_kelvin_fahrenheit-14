﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celsius_kelvin_fahrenheit_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the amount of celsius");
            int celsius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kelvin={0}", celsius + 273);
            Console.WriteLine("Fahrenheit={0}", celsius * 18 / 10 + 32);
            Console.ReadLine();
        }
    }
}

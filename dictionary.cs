﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class dictionary
    {
        public static void Main(string[] args)
        {
            IDictionary<int, int> d = new Dictionary<int, int>();
            d.Add(1, 97);
            d.Add(2, 89);
            d.Add(3, 77);
            d.Add(4, 88);

            Console.WriteLine("dictionary elements :" + d.Count);
            Console.ReadLine();

        }
    }
}

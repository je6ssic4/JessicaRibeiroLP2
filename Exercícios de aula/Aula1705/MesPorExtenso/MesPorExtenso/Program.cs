﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesPorExtenso
{
    class Program
    {
        static void Main(string[] args)
        {
            string d;//DD/MM/AAA
            Console.WriteLine("Digite a data:");
            d = Console.ReadLine();

            if(d.Substring(3,2)== "01")
            {
                Console.WriteLine("janeiro");
            }
            if (d.Substring(3,2) == "02")
            {
                Console.WriteLine("fevereiro");
            }
            if (d.Substring(3, 2) == "03")
            {
                Console.WriteLine("março");
            }
            if (d.Substring(3, 2) == "04")
            {
                Console.WriteLine("abril");
            }
            if (d.Substring(3, 2) == "05")
            {
                Console.WriteLine("maio");
            }
            if (d.Substring(3, 2) == "06")
            {
                Console.WriteLine("junho");
            }
            if (d.Substring(3, 2) == "07")
            {
                Console.WriteLine("julho");
            }
            if (d.Substring(3, 2) == "08")
            {
                Console.WriteLine("agosto");
            }
            if (d.Substring(3, 2) == "09")
            {
                Console.WriteLine("setembro");
            }
            if (d.Substring(3, 2) == "10")
            {
                Console.WriteLine("outubro");
            }
            if (d.Substring(3, 2) == "11")
            {
                Console.WriteLine("novembro");
            }
            if (d.Substring(3, 2) == "12")
            {
                Console.WriteLine("dezembro");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompeticaoDeCorrida
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos competidores?");
            int comp = int.Parse(Console.ReadLine());

            for (int i = 0; i <= comp; i++) ;
            {
                Console.WriteLine("Qual o nome do competidor?");
                string nome = Console.ReadLine();

                Console.WriteLine("Qual o primeiro tempo do competidor?");
                double temp1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Qual o segundo tempo do competidor?");
                double temp2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Qual o terceiro tempo do competidor?");
                double temp3 = Convert.ToDouble(Console.ReadLine());

            }
        }
    }
}

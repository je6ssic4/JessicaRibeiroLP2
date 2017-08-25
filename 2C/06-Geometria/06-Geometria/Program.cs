using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Geometria
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Triangulo a = new Triangulo();

            Console.WriteLine("Qual a base do triângulo?");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual a altura do triângulo?");
            int h = int.Parse(Console.ReadLine());

            Console.WriteLine("A área do triângulo é de:{0}", a.Area());

        }
    }
}

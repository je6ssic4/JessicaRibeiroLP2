using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosNoPlano
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 600, L = 800;

            Console.WriteLine("Digite X inicial:");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite Y inicial:");
            int y = int.Parse(Console.ReadLine());

            Objeto2D obj = new Objeto2D();


            Console.WriteLine("Digite um comando: ");
            ConsoleKey comando = Console.ReadKey().Key;

            if (comando == ConsoleKey.RightArrow)
            {
                obj.AndarParaADireita();
                Console.WriteLine(obj.Coordenadas());
            }
                

        }
    }
}

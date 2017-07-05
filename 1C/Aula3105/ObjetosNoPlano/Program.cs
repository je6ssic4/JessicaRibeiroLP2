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


            Circulo obj = new Circulo();
            obj.x = x;
            obj.y = y;
            Console.WriteLine("Digite Raio inicial:");
            obj.raio = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um comando: ");

            while (true) 
            {
                ConsoleKey comando = Console.ReadKey().Key;


                    if (comando == ConsoleKey.RightArrow && obj.x < 800)
                    {
                        obj.AndarParaADireita();
                    }
                    if (comando == ConsoleKey.LeftArrow && obj.x > 0)
                    {
                        obj.AndarParaAEsquerda();
                    }
                    if (comando == ConsoleKey.UpArrow && obj.y < 600)
                    {
                        obj.VaParaCima();
                    }
                    if (comando == ConsoleKey.DownArrow && obj.y > 0)
                    {
                        obj.VaParaBaixo();
                    }
                
              if(obj.x < 800 && obj.y < 600)
              {
                  Console.WriteLine(obj.Coordenadas());
              }

             
            }
                

        }
    }
}

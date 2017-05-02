using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_da_aula_2604
{
    class Program
    {
        static void Main(string[] args)
        {
            int pot, qtd;
            string modelo, valor;
            double km;
            

            Console.WriteLine("Qual a quantidade de veículos do galpão?");
            qtd = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= qtd; i++);
            {
                valor = Classificar(modelo, km, pot);

                if(km <= 5000)
                
                    Console.WriteLine("Novo",km);
                
                else if(km > 5000 && km <= 30000)
                
                    Console.WriteLine("Seminovo",km);
                
                else
                
                    Console.WriteLine("Velho",km);

                if (pot <= 120)

                    Console.WriteLine("Popular", pot);


                else if (pot > 120 && pot <= 200)
                   
                     Console.WriteLine("Forte", pot);
                else
                   
                    Console.WriteLine("Potente", pot);

            }
            
            Console.WriteLine("Carro:{0},{1},{2}", modelo, km, pot);

        }
    }

    static string Classificar (string modelo, double km, int pot)
    {
         
         Console.WriteLine("Qual o modelo do carro?");
         modelo = Console.ReadLine();
                
         Console.WriteLine("Qual a quilometragem do carro?");
         km = Convert.ToDouble(Console.ReadLine());

         Console.WriteLine("Qual a potência do carro?");
         pot = Convert.ToInt32(Console.ReadLine());

         return Classificar;
    }
        }
    }
}

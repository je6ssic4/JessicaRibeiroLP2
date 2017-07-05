using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContagemDeVogais
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto;
            int vogal = 0;

            Console.WriteLine("Digite o texto:");
            texto = Console.ReadLine();


            for (int i = 0; i < texto.Length; i++)
            {
                if (texto[i] == 'a' || texto[i] == 'e' || texto[i] == 'i' || texto[i] == 'o' || texto[i] == 'u' || texto[i] == 'A' || texto[i] == 'E' || texto[i] == 'I' || texto[i] == 'O' || texto[i] == 'U')
                {
                    vogal++;
                }
            }
            Console.WriteLine("O texto tem {0} vogais", vogal);
        }

    }
}

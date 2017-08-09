using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_CodigoMorse
{
    class Mensagem
    {
        public string texto;
        public string tabela { get; }

        public string Codificar()
        {
            Console.WriteLine("Digite o texto:");
            texto = Console.ReadLine();

            return texto;
        }

    }
}

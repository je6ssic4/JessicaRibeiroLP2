using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Normal pessoa = new Normal();
            pessoa.Nome = "Jéssica";
            pessoa.Number = 11;

            Console.WriteLine("{0}, {1}", pessoa.Nome, pessoa.Number);
        }
    }
}

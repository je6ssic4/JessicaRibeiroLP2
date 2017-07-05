using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_LeituraOtica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o número de questões?");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string resp = "x";
                int qtdOk = 0, qtdAmb = 0;

                int A = int.Parse(Console.ReadLine());
                int B = int.Parse(Console.ReadLine());
                int C = int.Parse(Console.ReadLine());
                int D = int.Parse(Console.ReadLine());
                int E = int.Parse(Console.ReadLine());

                if(A <= 100)
                {
                    resp = "A";
                    qtdOk++;
                }
                else if(A <= 155)
                {
                    qtdAmb++;
                }
                if(B <= 100)
                {
                    resp = "B";
                    qtdOk++;
                }
                else if(B <= 155)
                {
                    qtdAmb++;
                }
                if(C <= 100)
                {
                    resp = "C";
                    qtdOk++;
                }
                else if(C <= 155)
                {
                    qtdAmb++;
                }
                if(D <= 100)
                {
                    resp = "D";
                    qtdOk++;
                }
                else if(D <= 155)
                {
                    qtdAmb++;
                }
                if(E <= 100)
                {
                    resp = "E";
                    qtdOk++;
                }
                else if(E <= 155)
                {
                    qtdAmb++;
                }
                if (qtdOk == 1 && qtdAmb == 0)
                {
                    Console.WriteLine(resp);
                }
                else
                    Console.WriteLine("*");
            }

        }
    }
}

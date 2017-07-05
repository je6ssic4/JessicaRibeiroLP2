using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_LivrosHermione
{
    class Livro
    {
        public string titulo;
        public int qtdPag, pagPoH, HoraPorDia, diasLendo, pagPorDia;

        public double TempLeitura(int pagPoH)
        {
            pagPorDia = pagPoH * HoraPorDia;
            double diasLendo = qtdPag / pagPorDia;

            return diasLendo; 

        }
    }
}

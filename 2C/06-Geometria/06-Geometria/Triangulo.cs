using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Geometria
{
    class Triangulo
    {
        private int B; {get; set;}
        private int H; {get; set;}
        public int Area(int B, int H)
        {
            int t;
            
            t = (B * H) / 2;

            return t;
        }
    }
}

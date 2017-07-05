using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosNoPlano
{
    class Circulo
    {
        public int x;
        public int y;
        public int raio;
        public int R;
        public int G;
        public int B;

        public void AndarParaADireita()
        {
            x = x + 3;
        }

        public void AndarParaAEsquerda()
        {
            x = x - 3;
        }

        public void VaParaCima()
        {
            y = y + 3;
        }

        public void VaParaBaixo()
        {
            y = y - 3;
        }

        public string Coordenadas()
        {
            return String.Format("({0},{1})", x, y);
        }
        
    }
}

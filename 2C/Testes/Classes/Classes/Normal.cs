using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Normal
    {
        public string Nome { get; set; }
        public int Number { get; set; }

        public void Soma()
        {
            this.Number = Number + 3;
        }
        public void Multi()
        {
            this.Number = Number * 3;
        }
    }
}

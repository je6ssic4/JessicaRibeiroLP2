using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Produtos
{
    class Produto
    {
        private int id;
        public int Id {
            get { return id; }
        }
        private string nome;
        public string Nome {
            get { return nome; }
        }
        private int quantidade;
        public int Quantidade { 
            get { return quantidade; }
        }
        public double Preco { get; set; }

        public void Retirada(int qtd)
        {
            if (qtd <= this.quantidade)
            {
                this.quantidade -= qtd;
            }
            else
                throw new Exception("Quantidade supera estoque.");
        }
        public void Reposicao(int qtd)
        {
                quantidade += qtd;
        }
        public Produto(int id, string nome, double preco)
        {
            this.id = id;
            this.nome = nome;
            this.Preco = preco;
            this.quantidade = 0;
        }
        public string Imprimir()
        {
            return string.Format("Produto:{0}, {1} - R${2:0.00}", id, nome, Preco);
        }
 
   
    }

}

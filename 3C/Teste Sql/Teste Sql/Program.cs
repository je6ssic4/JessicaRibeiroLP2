using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Teste_Sql
{
    class Program
    {
        static void Main(string[] args)
        {
            int pot;
            string marca, modelo, cor, placa;

            Console.WriteLine("Qual a potência?");
            pot = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual a marca?");
            marca = Console.ReadLine();
            Console.WriteLine("Qual o modelo?");
            modelo = Console.ReadLine();
            Console.WriteLine("Qual a cor?");
            cor = Console.ReadLine();
            Console.WriteLine("Qual a placa?");
            placa = Console.ReadLine();

            SqlConnection conexao = new SqlConnection("Data Source=localhost;Initial Catalog=Carro;Integated Security=SSPI;");

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao;
            cmd.CommandText = @"INSERT
                                INT Carro
                                VALUES(marca,modelo,cor,placa,pot);";
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
           
        }
    }
}

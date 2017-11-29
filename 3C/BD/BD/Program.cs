using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Modelo: ");
            string modelo = Console.ReadLine();
            Console.WriteLine("Cor: ");
            string cor = Console.ReadLine();
            Console.WriteLine("Pot: ");
            int pot = int.Parse(Console.ReadLine());
            Console.WriteLine("Placa: ");
            string placa = Console.ReadLine();
            Console.WriteLine("Ano: ");
            string ano = Console.ReadLine();

            SqlCommand cmd = new SqlCommand()
            {
                Connection = new SqlConnection("Data Source=localhost; Initial Catalog=LP2 - Jéssica; Integrated Security=SSPI;"),

                //CommandText = @"DELETE
                            //  FROM Carro
                          //    WHERE Id = 2",

                /*CommandText = @"SELECT Id, Cor, Ano
                                FROM Carro"*/


                CommandText = String.Format(@"INSERT
                                              INTO Carro(Modelo, Cor, Placa, Potência, Ano)
                                              VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');", modelo, cor, placa, pot, ano)

                /* CommandText = @"INSERT
                                  INTO Professor(Nome, Siape, Salario)
                                  VALUES (@nome, @siape, @salario);       */
            };

            /* cmd.Parameters.AddWithValue("modelo", modelo);
             * cmd.Parameters.AddWithValue("cor", cor);
             * cmd.Parameters.AddWithValue("placa", placa); 
             * cmd.Parameters.AddWithValue("pot", pot); 
             * * cmd.Parameters.AddWithValue("ano", ano); */


            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

            Console.WriteLine("OK");

            /*try
            {
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                Console.WriteLine("OK");/
            }
            catch (Exception e)
            {
                Console.WriteLine("Um erro ocorreu. {0}", e.Message);
            } */


        }
    }
}

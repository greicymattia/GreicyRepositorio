using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //inserir bliblioteca

namespace BancoDeDados
{
    class Program_SQL
    {
        static void Main1(string[] args)
        {
            //CONNECTION STRING
            string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=c:\users\greicy\documents\visual studio 2013\Projects\GreicyRepositorio\BancoDeDados\BandoDeDados\GreicyDB.mdf;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            //ABRINDO CONEXÃO
            sqlConnection.Open();
            //REALIZAR COMANDOS
            //SqlCommand command = new SqlCommand("SELECT*FROM Produto ", sqlConnection);
            //SqlDataReader reader = command.ExecuteReader();           
            //while (reader.Read())
            //{
            //    Console.WriteLine(reader["Nome"]);
            //}
            //Console.WriteLine("Digite o Id do produto a ser editado: ");
            //int id = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Digite o nome do produto: ");
            //string nome = Console.ReadLine();
            //string sqlUpdate = String.Format("UPDATE Produto SET Nome = '{0}' WHERE Id = {1}", nome,id);
            //SqlCommand command = new SqlCommand(sqlUpdate, sqlConnection);
            //int i = command.ExecuteNonQuery();
            //try
            //{
            //    int i = command.ExecuteNonQuery();
            //    if(i>0)
            //    {          
            //          Console.WriteLine("Produto atualizado com sucesso!");
            //    }
            //}
            //catch(SqlException e){
            //    Console.WriteLine(e.ToString());
            //}
            //if (i > 0)
            //{
            //    Console.WriteLine("Produto atualizado com sucesso!");
            //}
            //else
            //{
            //    Console.WriteLine("FODEU!");
            //}
            //DELETA PRODUTO
            //Console.WriteLine("Digite o Id do produto a ser deletado: ");
            //int id = Convert.ToInt32(Console.ReadLine());            
            //string sqlDelete = String.Format("DELETE FROM Produto WHERE Id = {0}", id);
            //SqlCommand command = new SqlCommand(sqlDelete, sqlConnection);
            //try
            //{
            //    int i = command.ExecuteNonQuery();
            //    if (i > 0)
            //    {
            //        Console.WriteLine("Produto DELETADO com sucesso!");
            //    }
            //}
            //catch (SqlException e)
            //{
            //    Console.WriteLine(e.ToString());
            //}

            Console.WriteLine("Digite o nome do produto: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite a unidade do produto: ");
            string unidade = Console.ReadLine();
            Console.WriteLine("Digite o valor do produto: ");
            decimal valor = Convert.ToDecimal(Console.ReadLine());
            string sqlInsert = String.Format(" INSERT INTO Produto (Nome, Unidade, Valor) VALUES ('{0}', '{1}', '{2}')", nome, unidade, valor);
            SqlCommand command = new SqlCommand(sqlInsert, sqlConnection);
            try
            {
                int i = command.ExecuteNonQuery();
                if (i > 0)
                {
                    Console.WriteLine("Produto inserido com sucesso!");
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }


            //FECHA CONEXÃO
            sqlConnection.Close();
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            //CONNECTION STRING
            string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=c:\users\greicy\documents\visual studio 2013\Projects\GreicyRepositorio\BancoDeDados\BandoDeDados\GreicyDB.mdf;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            //ABRINDO CONEXÃO
            sqlConnection.Open();
            //REALIZAR COMANDOS

            //ALTERA CLIENTE            
            //SqlCommand command = new SqlCommand("SELECT*FROM Cliente ", sqlConnection);
            //SqlDataReader reader = command.ExecuteReader();           
            //while (reader.Read())
            //{
            //    Console.WriteLine(reader["Primeiro Nome"]);
            //}
            //Console.WriteLine("Digite o Id do cliente a ser editado: ");
            //int id = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Digite o primeiro nome do cliente: ");
            //string nome = Console.ReadLine();
            //string sqlUpdate = String.Format("UPDATE Cliente SET Primeiro Nome = '{0}' WHERE Id = {1}", nome,id);
            //SqlCommand command = new SqlCommand(sqlUpdate, sqlConnection);
            //int i = command.ExecuteNonQuery();
            //try
            //{
            //    int i = command.ExecuteNonQuery();
            //    if(i>0)
            //    {          
            //          Console.WriteLine("Cliente atualizado com sucesso!");
            //    }
            //}
            //catch(SqlException e){
            //    Console.WriteLine(e.ToString());
            //}
          
            //-----------------------------------------------------------------------------------------------------------------
            //DELETA CLIENTE
            //Console.WriteLine("Digite o Id do Cliente a ser deletado: ");
            //int id = Convert.ToInt32(Console.ReadLine());            
            //string sqlDelete = String.Format("DELETE FROM Cliente WHERE Id = {0}", id);
            //SqlCommand command = new SqlCommand(sqlDelete, sqlConnection);
            //try
            //{
            //    int i = command.ExecuteNonQuery();
            //    if (i > 0)
            //    {
            //        Console.WriteLine("Cliente DELETADO com sucesso!");
            //    }
            //}
            //catch (SqlException e)
            //{
            //    Console.WriteLine(e.ToString());
            //}
            //----------------------------------------------------------------------------------------------------------------------
            //CADASTRA CLIENTE
            Console.WriteLine("Digite o primeiro nome do cliente: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o sobrenome do cliente: ");
            string sobrenome = Console.ReadLine();
            Console.WriteLine("Digite a cidade do cliente: ");
            string cidade = Console.ReadLine();
            Console.WriteLine("Digite o estado do cliente: ");
            string UF = Console.ReadLine();
            Console.WriteLine("Digite o CEP do cliente: ");
            string CEP = Console.ReadLine();
            Console.WriteLine("Digite o CPF do cliente: ");
            string CPF = Console.ReadLine();
            Console.WriteLine("Digite o telefone do cliente: ");
            string tel = Console.ReadLine();
            string sqlInsert = String.Format(" INSERT INTO Cliente (PrimeiroNome, Sobrenome, Cidade, Estado, CEP, CPF, Telefone) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", nome, sobrenome, cidade, UF, CEP, CPF, tel);
            SqlCommand command = new SqlCommand(sqlInsert, sqlConnection);
            try
            {
                int i = command.ExecuteNonQuery();
                if (i > 0)
                {
                    Console.WriteLine("Cliente cadastrado com sucesso!");
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }


            //FECHA CONEXÃO
            sqlConnection.Close();
            Console.ReadKey();
        }
    }
}

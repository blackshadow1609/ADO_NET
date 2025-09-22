//ADO_NET
//ADO(ActiveX Data Object)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//ADO.NET:
using System.Data.SqlClient;

namespace ADO_NET
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//1) Создаем подключение к Базе данных на Сервере:
			string connectionString = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = Movies; Integrated Security = True";//Сама нашла, сама решила)))

            Console.WriteLine(connectionString);
			SqlConnection connection = new SqlConnection();
			connection.ConnectionString = connectionString;
			// После того как подключение создано, оно не является открытым,
			// то есть подключение всегда открывается вручную при необходимости.

			//2) Открывает соединение:
			connection.Open();

            //3) Создаем 'SqlCommand':
            string cmd = "SELECT * FROM Directors";
			SqlCommand command = new SqlCommand(cmd, connection);

            //4) Создаем 'Reader':
			SqlDataReader reader = command.ExecuteReader();
			for (int i = 0; i < reader.FieldCount; i++)
			{
				Console.Write(reader.GetName(i) + "\t");
			}
			Console.WriteLine();

			while (reader.Read())
			{
                //Console.WriteLine($"{reader[0]}\t{reader[1]}\t{reader[2]}");
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Console.Write(reader[i]+"\t\t");
                }
                  Console.WriteLine();
            }
			reader.Close();

            //?) !!!Подключения обязательно нужно закрывать!!! 
            connection.Close();


		}
	}
}

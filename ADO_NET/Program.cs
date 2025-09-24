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
        static string connectionString = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = Movies; Integrated Security = True";   //В моём случае работает только так
        static SqlConnection connection;
        static void Main(string[] args)
        {
            //1) Создаем подключение к Базе данных на Сервере:

            Console.WriteLine(connectionString);
            connection = new SqlConnection(connectionString);

            Select("*", "Directors");
            Select("movie_name, release_date, first_name+last_name AS director", "Movies, Directors", "director=director_id");


            Console.Write("Введите имя: ");
            string first_name = Console.ReadLine();

            Console.Write("Введите фамилию: ");
            string last_name = Console.ReadLine();

            
            Insert("Directors", "director_id, first_name, last_name",
                   $"{Convert.ToInt32(Scalar("SELECT MAX(director_id) FROM Directors")) + 1}, N'{first_name}', N'{last_name}'");

            Select("*", "Directors");

            
            Console.WriteLine("\n=== Параметризованный запрос ===");
            ParametrizedSelect("Directors", "first_name", "James"); 
        }

        
        static void Insert(string table, string columns, string values)
        {
            string cmd = $"INSERT {table}({columns}) VALUES ({values})";
            SqlCommand command = new SqlCommand(cmd, connection);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        
        static void ParametrizedSelect(string table, string conditionField, string conditionValue)
        {
            connection.Open();

            
            string cmd = $"SELECT * FROM {table} WHERE {conditionField} = @value";
            SqlCommand command = new SqlCommand(cmd, connection);

           
            command.Parameters.AddWithValue("@value", conditionValue);

            SqlDataReader reader = command.ExecuteReader();

           
            for (int i = 0; i < reader.FieldCount; i++)
            {
                Console.Write(reader.GetName(i) + "\t");
            }
            Console.WriteLine();

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Console.Write(reader[i] + "\t\t");
                }
                Console.WriteLine();
            }
            reader.Close();

            connection.Close();
        }

        static void Select(string fields, string tables, string condition = "")
        {
            //2) Открывает соединение:
            connection.Open();

            //3) Создаем 'SqlCommand':
            string cmd = $"SELECT {fields} FROM {tables}";
            if (condition != "") cmd += $" WHERE {condition}";
            cmd += ";";
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

                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Console.Write(reader[i] + "\t\t");
                }
                Console.WriteLine();
            }
            reader.Close();

            //?) !!!Подключения обязательно нужно закрывать!!! 
            connection.Close();
        }
        static object Scalar(string cmd)
        {
            connection.Open();
            SqlCommand command = new SqlCommand(cmd, connection);
            object obj = command.ExecuteScalar();
            connection.Close();
            return obj;
        }
    }
}
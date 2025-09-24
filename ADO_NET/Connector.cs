using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ADO_NET
{
	internal class Connector
	{
        string connectionString = "";
        protected SqlConnection connection;
        public Connector(string connectionString)
        {
            this.connectionString = connectionString;
            connection = new SqlConnection(connectionString);
			Console.WriteLine(connectionString);
        }
        public void Insert(string table, string fields, string values)
        {
            string primary_key = Scalar
                (
                    $@"SELECT COLUMN_NAME 
                    FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE 
                    WHERE OBJECTPROPERTY(OBJECT_ID(CONSTRAINT_SCHEMA+'.'+QUOTENAME(CONSTRAINT_NAME)), 'IsPrimaryKey')=1 
                    AND    TABLE_NAME='{table}'"
                ) as string;

            Console.WriteLine("\n===========================================================\n");
            Console.WriteLine(primary_key);
            Console.WriteLine("\n===========================================================\n");
            string[] fields_for_check = fields.Split(',');
            string[] values_for_check = values.Split(',');
            string condition = "";
            for (int i = 1; i < fields_for_check.Length; i++)
            {
                condition += $" {fields_for_check[i]}={values_for_check[i]} AND";
            }

            int index_of_last_space = condition.LastIndexOf(' ');
            Console.WriteLine($"Condition Length:{condition.Length}");
            Console.WriteLine($"Last space index:{index_of_last_space}");

            condition = condition.Remove(condition.LastIndexOf(' '), 4);

            string cmd = $"IF NOT EXISTS(SELECT {primary_key} FROM {table} WHERE {condition})BEGIN INSERT {table} ({fields}) VALUES ({values}); END";

            SqlCommand command = new SqlCommand(cmd, connection);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }


        public void Select(string fields, string table, string condition = "")
        {
            //2) Открывает соединение:
            connection.Open();

            //3) Создаем 'SqlCommand':
            string cmd = $"SELECT {fields} FROM {table}";
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
                //Console.WriteLine($"{reader[0]}\t{reader[1]}\t{reader[2]}");
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
        public object Scalar(string cmd)
        {
            connection.Open();
            SqlCommand command = new SqlCommand(cmd, connection);
            object obj = command.ExecuteScalar();
            connection.Close();
            return obj;
        }
        public void SelectWithParameters(string first_name, string last_name)
        {
            string cmd = 
                @"
                SELECT movie_name, release_date, last_name, first_name 
                FROM Movies, Directors 
                WHERE director=director_id 
                AND last_name=@last_name 
                AND first_name=@first_name;
                ";

            //SqlParameter parameter = new SqlParameter();
            SqlCommand command = new SqlCommand(cmd, connection);
            command.Parameters.Add(new SqlParameter("@last_name", System.Data.SqlDbType.NVarChar) { Value = last_name });
            command.Parameters.Add(new SqlParameter("@first_name", System.Data.SqlDbType.NVarChar) { Value = first_name });
            //command.Parameters.Add(new SqlParameter("@last_name", System.Data.SqlDbType.NVarChar).Value = last_name);
            //command.Parameters.Add(new SqlParameter("@first_name", System.Data.SqlDbType.NVarChar).Value = first_name);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Console.Write(reader.GetName(i) + "\t");
					Console.WriteLine();
                }
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                    Console.WriteLine(reader[i] + "\t");
				    Console.WriteLine();
            }
            connection.Close();
        }
    }
}

//ADO_NET
//ADO(ActiveX Data Object)
//#define SCALAR_CHEK
//#define ALL_IN_MAIN_CLASS
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//ADO.NET:
using System.Data.SqlClient;
using System.Configuration;

namespace ADO_NET
{
    internal class Program
    {
#if ALL_IN_MAIN_CLASS
        static string connectionString = "";
        static SqlConnection connection; 
#endif
        static void Main(string[] args)
        {
#if ALL_IN_MAIN_CLASS
            //0) Достаем строку подключения из App.config:
            connectionString = ConfigurationManager.ConnectionStrings["Movies"].ConnectionString;

            //1) Создаем подключение к Базе данных на Сервере:
            Console.WriteLine(connectionString);
            connection = new SqlConnection(connectionString); //Инициализация статического поля
            //После того как подключение создано, оно не является открытым,
            //то есть подключение всегда открывается вручную при необходимости.
            //Select("SELECT * FROM Directors");
            //Select("SELECT * FROM Movies");
            Select("*", "Directors");
            Select("movie_name, release_date, first_name+last_name AS director", "Movies, Directors", "director=director_id"); 
#endif

#if SCALAR_CHEK
            connection.Open();
            string cmd = "SELECT COUNT(*) FROM Directors";
            SqlCommand command = new SqlCommand(cmd, connection);
            Console.WriteLine($"Количество режиссеров:\t{command.ExecuteScalar()}");

            command.CommandText = "SELECT COUNT(*) FROM Movies";
            Console.WriteLine($"Количество фильмов:\t{command.ExecuteScalar()}");

            command.CommandText = "SELECT last_name FROM Directors WHERE first_name=N'James'";
            Console.WriteLine(command.ExecuteScalar());

            connection.Close();

            Console.WriteLine(Scalar("SELECT last_name FROM Directors WHERE first_name=N'James'"));
            Console.WriteLine(Scalar("SELECT COUNT(*) FROM Movies")); 
#endif
            //InsertDirector();
            //InsertMovie();

            //MovieConnector movie_connector = new MovieConnector(ConfigurationManager.ConnectionStrings["Movies"].ConnectionString);
            //movie_connector.SelectDirectors();
            //movie_connector.SelectMovies();
            //movie_connector.InsertDirector();
            // movie_connector.InsertMovie();
            //movie_connector.Select("*", "Movies, Directors", "director=director_id; DROP TABLE Actors");

            Connector connector = new Connector(ConfigurationManager.ConnectionStrings["Movies"].ConnectionString);
            connector.SelectWithParameters("James", "Cameron");
        }
    }
}

//"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Movies;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
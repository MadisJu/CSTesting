using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using MySql.Data;
using MySql.Data.MySqlClient;


// Following this to actually make myself a database https://dev.mysql.com/doc/connector-net/en/connector-net-tutorials-intro.html

//Starting example for myself to familirize with which is taken from mircrosoft page
//int[] scores = new int[] { 97, 92, 81, 60 };

//// Define the query expression.
//IEnumerable<int> scoreQuery =
//    from score in scores
//    where score > 80
//    select score;

//// Execute the query.
//foreach (int i in scoreQuery)
//{
//    Console.Write(i + " ");
//}

namespace LINQ_Learning
{
    class Program
    {

        public static MySqlConnection connection;
        public static MySqlCommand command;

        static void Connect_To_DB()
        {
            string connectionString = "server=localhost;user=root;database=data;port=3306;password=DeliaIsLub0712";

            connection = new MySqlConnection(connectionString);

            try
            {
                Console.WriteLine("Opening Database");
                connection.Open();
            }
            catch(Exception exception)
            {
                Console.WriteLine("Error has occured: " + exception.ToString());
            }

        }

        private static void AddFoodsToDatabase(string name, int calories, double price)
        {
            command.CommandText = "INSERT INTO foods VALUES('" + name + "', " + calories + ", " + price + ")"; 

            command.Prepare();

            command.ExecuteNonQuery();

        }

        private static void init()
        {
            command = new MySqlCommand("", connection);
        }
        static void Main(string[] args)
        {

            Connect_To_DB();
            init();

            while(true)
            {
                Console.WriteLine("Input your input");
                string input = Console.ReadLine();

                if(input.ToLower() == "insert")
                {
                    Console.WriteLine("Please input the foods name, calories and price");
                    AddFoodsToDatabase(Console.ReadLine(), int.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
                }
                else if(input.ToLower() == "break")
                {
                    break;
                }
                else if(input.ToLower() == "check")
                {
                    command.CommandText = "SELECT * FROM foods";

                    command.Prepare();

                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Console.WriteLine(reader[0] + "--" + reader[1] + "--" + reader[2]);
                    }
                    reader.Close();
                }
                Console.WriteLine("///////////////");

            }

            connection.Close();
        }
    }
}

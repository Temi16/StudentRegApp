using System;
using MySql.Data.MySqlClient;
using StudentRegistrationApp.Managers;

namespace StudentRegistrationApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var connectionString = "server=localhost;user=root;database=student_registration;port=3306;password=temidayo16120";
            MySqlConnection connection = new MySqlConnection(connectionString);

            RegistrarManager registrarManager = new RegistrarManager(connection);

            var registrar = registrarManager.GetRegistrarById();

            Console.WriteLine(registrar.StaffNumber + "\t" + registrar.LastName);


            Console.WriteLine("Hello World!");
        }
    }
}

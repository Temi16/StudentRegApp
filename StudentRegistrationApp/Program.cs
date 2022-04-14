using System;
using MySql.Data.MySqlClient;
using StudentRegistrationApp.Managers;
using StudentRegistrationApp.Menus;

namespace StudentRegistrationApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var connectionString = "server=localhost;user=root;database=student_registration;port=3306;password=Oluwatobiloba007";
            MySqlConnection connection = new MySqlConnection(connectionString);

            MainMenu menu = new MainMenu(connection);
            menu.Menu();


        }
    }
}

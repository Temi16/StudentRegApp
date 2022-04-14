using MySql.Data.MySqlClient;
using StudentRegistrationApp.Interfaces;
using StudentRegistrationApp.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistrationApp.Menus
{
    public class MainMenu
    {
        private readonly RegistrarMenu registrarMenu;
        private readonly StudentMenu studentMenu;
        public MainMenu(MySqlConnection connection)
        {
            registrarMenu = new RegistrarMenu(connection);
            studentMenu = new StudentMenu(connection);
        }

        public void Menu()
        {
            var exit = false;

            while (!exit)
            {
                Console.Clear();
                PrintMenu();
                int op;
                if (int.TryParse(Console.ReadLine(), out op))
                {
                    switch (op)
                    {
                        case 1:
                            registrarMenu.Menu();
                            break;
                        case 2:
                            studentMenu.Menu();
                            break;
                        case 0:
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Invalid inpute...\nPress any key to try again...");
                            Console.ReadKey();
                            break;
                    }
                }

            }
        }

        private void PrintMenu()
        {
            Console.WriteLine("=================================================");
            Console.WriteLine("====== Welcome to CLH Student Register App ======");
            Console.WriteLine("=================================================");
            Console.WriteLine();
            Console.WriteLine("1.\tStaff Menu.");
            Console.WriteLine("2.\tStudent Menu.");
            Console.WriteLine("0.\tExit.");
        }
    }
}

using MySql.Data.MySqlClient;
using StudentRegistrationApp.Entities;
using StudentRegistrationApp.Interfaces;
using StudentRegistrationApp.Managers;
using System;

namespace StudentRegistrationApp.Menus
{
    public class RegistrarMenu
    {
        private readonly IRegistrarManager registrarManager;
        public RegistrarMenu(MySqlConnection connection)
        {
            registrarManager = new RegistrarManager(connection);
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
                            var registrar = registrarManager.Login();
                            if(registrar != null)
                            {
                                //call other menu....
                                OtherMenu(registrar);
                            }
                            else
                            {
                                Console.WriteLine("Invalid email or password.");
                            }
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
            Console.WriteLine("===========================================");
            Console.WriteLine("====== Welcome to CLH Registrar Menu ======");
            Console.WriteLine("===========================================");
            Console.WriteLine();
            Console.WriteLine("1.\tLogin.");
            Console.WriteLine("0.\tExit.");
        }

        private void PrintOtherMenu()
        {
            Console.WriteLine();
            Console.WriteLine("1.\t.View all pending applications.");
            Console.WriteLine("2.\t.View all admitted students.");
            Console.WriteLine("3.\t.View all declined applications.");
            Console.WriteLine("4.\t.Admit students.");
            Console.WriteLine("5.\t.Add new registrar.");
            Console.WriteLine("6.\t.Get all registrar.");
            Console.WriteLine("7.\t.Get a registrar by email.");
            Console.WriteLine("8.\t.Update a registrar.");
            Console.WriteLine("9.\t.Delete a registrar.");
            Console.WriteLine("10.\t.Add new registrar.");
            Console.WriteLine("0.\tExit.");
        }

        private void OtherMenu(Registrar registrar)
        {
            var exit = false;

            while (!exit)
            {
                Console.Clear();
                PrintOtherMenu();
                int op;
                if (int.TryParse(Console.ReadLine(), out op))
                {
                    switch (op)
                    {
                        case 1:
                            //////call the method to display all pending applications
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
    }
}

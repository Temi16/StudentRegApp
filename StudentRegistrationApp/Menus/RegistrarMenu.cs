﻿using MySql.Data.MySqlClient;
using StudentRegistrationApp.Interfaces;
using StudentRegistrationApp.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}

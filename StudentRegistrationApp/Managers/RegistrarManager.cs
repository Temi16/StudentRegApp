using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using StudentRegistrationApp.Entities;

namespace StudentRegistrationApp.Managers
{
    public class RegistrarManager
    {
        MySqlConnection _connection;

        public RegistrarManager(MySqlConnection connection)
        {
            _connection = connection;
        }

        public void AddNewRegistrar()
        {
            Console.Write("Enter registrar first name: ");
            var firstName = Console.ReadLine();
            Console.Write("Enter registrar last name: ");
            var lastName = Console.ReadLine();
            Console.Write("Enter registrar email: ");
            var email = Console.ReadLine();
            Console.Write("Enter registrar password: ");
            var password = Console.ReadLine();
            Console.Write("Enter registrar phone number: ");
            var phone = Console.ReadLine();
            Console.Write("Enter registrar address: ");
            var address = Console.ReadLine();
            var staffNo = $"RE-{Guid.NewGuid().ToString().Replace("-", "").Substring(0,5).ToUpper()}";

            try
            {
                _connection.Open();
                string query = "insert into registrars (first_name, last_name, email, password, phone_number, address, staff_no) values('"+firstName+"', '"+lastName+ "', '" + email + "', '" + password + "', '" + phone + "', '" + address + "', '"+staffNo+"')";

                MySqlCommand command = new MySqlCommand(query, _connection);
                int count = command.ExecuteNonQuery();
                if(count > 0)
                {
                    _connection.Close();
                    Console.WriteLine("Registrar added successfully.");
                    return;
                }
                Console.WriteLine("Failed to add registrar.");
            }
            catch(MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public Registrar GetRegistrarById()
        {
            Console.Write("Enter the id of Registrar to find: ");
            var id = int.Parse(Console.ReadLine());

            Registrar registrar = null;
            try
            {
                _connection.Open();
                string query = "select * from registrars where id = '"+id+"'";
                MySqlCommand command = new MySqlCommand(query, _connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string staffNo = reader.GetString(1);
                    string firstName = reader.GetString(2);
                    var lastName = reader.GetString(3);
                    var email = reader.GetString(4);
                    var password = reader.GetString(5);
                    var address = reader.GetString(6);
                    var phone = reader.GetString(7);

                    registrar = new Registrar(id,firstName, lastName, address, phone, email, password, staffNo);
                    
                }
            }catch(MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            _connection.Close();
            return registrar;
        }

        public List<Registrar> GetAllRegistrars()
        {
            
            List<Registrar> registrars = new List<Registrar>();
            try
            {
                _connection.Open();
                string query = "select * from registrars";
                MySqlCommand command = new MySqlCommand(query, _connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var id = reader.GetInt32(0);
                    string staffNo = reader.GetString(1);
                    string firstName = reader.GetString(2);
                    var lastName = reader.GetString(3);
                    var email = reader.GetString(4);
                    var password = reader.GetString(5);
                    var address = reader.GetString(6);
                    var phone = reader.GetString(7);

                    var registrar = new Registrar(id, firstName, lastName, address, phone, email, password, staffNo);
                    registrars.Add(registrar);

                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            _connection.Close();
            return registrars;
        }
    }
}

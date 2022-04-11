using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistrationApp.Entities
{
    public abstract class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public Person(int id, string firstName, string lastName, string address, string phoneNumber, string email, string password)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            PhoneNumber = phoneNumber;
            Email = email;
            Password = password;
        }
    }
}

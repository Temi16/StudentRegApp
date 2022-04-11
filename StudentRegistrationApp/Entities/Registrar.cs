using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistrationApp.Entities
{
    public class Registrar : Person
    {
        public string StaffNumber { get; set; }

        public Registrar(int id, string firstName, string lastName, string address, string phoneNumber, string email, string password, string staffNumber) : base(id, firstName, lastName, address, phoneNumber, email, password)
        {
            StaffNumber = staffNumber;
        }
    }
}

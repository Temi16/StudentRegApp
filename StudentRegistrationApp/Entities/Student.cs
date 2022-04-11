using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistrationApp.Entities
{
    public class Student : Person
    {
        public string RefrenceNo { get; set; }
        public int Age { get; set; }

        public Student(int id, string firstName, string lastName, string address, string phoneNumber, string email, string password, string refrenceNo, int age):base(id, firstName, lastName, address, phoneNumber, email, password)
        {
            RefrenceNo = refrenceNo;
            Age = age;
        }
    }
}

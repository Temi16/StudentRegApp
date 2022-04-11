using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistrationApp.Entities
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int FacultyId { get; set; }
        public Faculty Faculty { get; set; }   
    }
}

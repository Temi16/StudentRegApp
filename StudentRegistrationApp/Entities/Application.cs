using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentRegistrationApp.Enums;

namespace StudentRegistrationApp.Entities
{
    public class Application
    {
        public int Id { get; set; }
        public ApplicationStatus Status { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}

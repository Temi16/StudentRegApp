using StudentRegistrationApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistrationApp.Interfaces
{
    public interface IRegistrarManager
    {
        public Registrar Login();
        public void AddNewRegistrar();
        public Registrar GetRegistrarById(int id);
        public Registrar GetRegistrarByEmail(string staffEmail);
        public void UpdateRegistrar();
        public void DeleteRegistrar();
        public List<Registrar> GetAllRegistrars();
    }
}

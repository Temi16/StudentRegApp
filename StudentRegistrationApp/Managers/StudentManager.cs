using MySql.Data.MySqlClient;
using StudentRegistrationApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistrationApp.Managers
{
    public class StudentManager: IStudentManager
    {
        MySqlConnection _connection;

        public StudentManager(MySqlConnection connection)
        {
            _connection = connection;
        }
    }
}

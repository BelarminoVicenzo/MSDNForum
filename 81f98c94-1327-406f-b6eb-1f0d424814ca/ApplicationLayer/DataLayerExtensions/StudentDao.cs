using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.DataLayerExtensions
{
    static class StudentDao
    {
        public static IEnumerable<Dtos.Student> GetStudents(this DataLayer.StudentDao studentDao)
        {
            return new List<Dtos.Student>
            {
                new Dtos.Student{ Name = "Student1", Class = 1},
                new Dtos.Student{ Name = "Student2", Class = 2},
            };
        }
    }
}

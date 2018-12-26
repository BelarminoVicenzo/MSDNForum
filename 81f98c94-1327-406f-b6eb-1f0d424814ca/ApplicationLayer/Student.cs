using ApplicationLayer.DataLayerExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer
{
    public class Student : IStudent
    {
        public IEnumerable<Dtos.StudentVerifyResult> CheckAllStudents()
        {
            int[] classes = { 1, 2 };
            List<Dtos.StudentVerifyResult> result = new List<Dtos.StudentVerifyResult>();
            foreach(int c in classes)
            {
                BusinessLayer.Contracts.IStudentDao studentDao = new DataLayer.StudentDao();
                foreach(var student in studentDao.GetStudentsToVerify(c))
                {
                    result.Add(new Dtos.StudentVerifyResult { Name = student.Name, Class = student.Class, Approved = student.Verify() });
                }
            }
            return result;
        }
        public IEnumerable<Dtos.Student> GetStudents()
        {
            DataLayer.StudentDao studentDao = new DataLayer.StudentDao();
            return studentDao.GetStudents();
        }
    }
}

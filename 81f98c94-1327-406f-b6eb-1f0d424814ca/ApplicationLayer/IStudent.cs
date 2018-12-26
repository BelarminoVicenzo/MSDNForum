using System.Collections.Generic;

namespace ApplicationLayer
{
    public interface IStudent
    {
        IEnumerable<Dtos.StudentVerifyResult> CheckAllStudents();
        IEnumerable<Dtos.Student> GetStudents();
    }
}
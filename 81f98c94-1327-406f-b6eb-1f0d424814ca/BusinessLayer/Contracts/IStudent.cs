using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Contracts
{
    public interface IStudentDao
    {
        IEnumerable<Entities.Student> GetStudentsToVerify(int Class);
        void Save(Entities.Student student);
    }
}

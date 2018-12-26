using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Entities;

namespace DataLayer
{
    public class StudentDao : BusinessLayer.Contracts.IStudentDao
    {
        /// <summary>
        /// This method is defined by contract from business layer
        /// </summary>
        /// <param name="Class"></param>
        /// <returns></returns>
        public IEnumerable<Student> GetStudentsToVerify(int Class)
        {
            if (Class == 1)
                return new List<BusinessLayer.Entities.Student>
            {
                new Student
                {
                    Name = "Student 1",
                    Class = 1,
                    Subjects = new List<BusinessLayer.Entities.Subject>
                    {
                        new Subject { Class = 1, Credits = 5, Finished = true },
                        new Subject { Class = 1, Credits = 4, Finished = true },
                        new Subject { Class = 1, Credits = 6, Finished = true },
                        new Subject { Class = 1, Credits = 8, Finished = true },
                        new Subject { Class = 1, Credits = 1, Finished = true },
                        new Subject { Class = 1, Credits = 2, Finished = true },
                        new Subject { Class = 1, Credits = 5, Finished = true },
                        new Subject { Class = 1, Credits = 4, Finished = true },
                        new Subject { Class = 1, Credits = 6, Finished = true },
                        new Subject { Class = 1, Credits = 8, Finished = true },
                        new Subject { Class = 1, Credits = 1, Finished = false },
                        new Subject { Class = 1, Credits = 2, Finished = true },
                    }
                }
            };
            else if (Class == 2)
                return new List<BusinessLayer.Entities.Student>
                {
                new Student
                {
                    Name = "Student 2",
                    Class = 2,
                    Subjects = new List<BusinessLayer.Entities.Subject>
                    {
                        new Subject { Class = 1, Credits = 5, Finished = true },
                        new Subject { Class = 1, Credits = 4, Finished = true },
                        new Subject { Class = 1, Credits = 6, Finished = true },
                        new Subject { Class = 1, Credits = 8, Finished = true },
                        new Subject { Class = 1, Credits = 1, Finished = true },
                        new Subject { Class = 1, Credits = 2, Finished = true },
                        new Subject { Class = 1, Credits = 5, Finished = true },
                        new Subject { Class = 1, Credits = 4, Finished = true },
                        new Subject { Class = 1, Credits = 6, Finished = true },
                        new Subject { Class = 1, Credits = 8, Finished = true },
                        new Subject { Class = 1, Credits = 1, Finished = false },
                        new Subject { Class = 1, Credits = 2, Finished = true },

                        new Subject { Class = 2, Credits = 5, Finished = true },
                        new Subject { Class = 2, Credits = 4, Finished = true },
                        new Subject { Class = 2, Credits = 6, Finished = true },
                        new Subject { Class = 2, Credits = 8, Finished = true },
                        new Subject { Class = 2, Credits = 1, Finished = true },
                        new Subject { Class = 2, Credits = 2, Finished = true },
                        new Subject { Class = 2, Credits = 5, Finished = true },
                        new Subject { Class = 2, Credits = 4, Finished = true },
                        new Subject { Class = 2, Credits = 6, Finished = true },
                        new Subject { Class = 2, Credits = 8, Finished = true },
                        new Subject { Class = 2, Credits = 1, Finished = false },
                        new Subject { Class = 2, Credits = 2, Finished = true },
                    }
                }
            };
            throw new NotSupportedException();
        }

        /// <summary>
        /// This method saves student business entity back to database
        /// </summary>
        /// <param name="student"></param>
        public void Save(Student student)
        {
        }
    }
}

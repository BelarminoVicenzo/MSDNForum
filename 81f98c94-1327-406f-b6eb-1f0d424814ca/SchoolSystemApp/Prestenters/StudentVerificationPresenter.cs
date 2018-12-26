using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystemApp.Prestenters
{
    class StudentVerificationPresenter
    {
        private readonly Views.IStudentVerificationView view;
        private readonly List<Models.StudentVerification> model = new List<Models.StudentVerification>();
        public StudentVerificationPresenter(Views.IStudentVerificationView view)
        {
            this.view = view;
            ApplicationLayer.IStudent student = new ApplicationLayer.Student();
            model.Clear();
            foreach(var result in student.CheckAllStudents())
            {
                model.Add(new Models.StudentVerification { Name = result.Name, Result = result.Approved ? "Approved" : "Failed", Class = result.Class });
            }
            view.DataSource = model;
        }
    }
}

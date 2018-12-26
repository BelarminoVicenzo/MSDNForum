using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystemApp.Prestenters
{
    class StudentListPresenter
    {
        private readonly List<Models.StudentList> model = new List<Models.StudentList>();
        private readonly Views.IStudentListView view;

        public StudentListPresenter(Views.IStudentListView view)
        {
            this.view = view;
        }
        public void LoadStudents()
        {
            model.Clear();
            ApplicationLayer.IStudent student = new ApplicationLayer.Student();
            foreach(var studentDto in student.GetStudents())
            {
                model.Add(new Models.StudentList { Class = studentDto.Class, Name = studentDto.Name });
            }
            view.StudentDataSource = model;
        }

        internal void Verify()
        {
            new Views.StudentVerificationView().ShowDialog();
        }
    }
}

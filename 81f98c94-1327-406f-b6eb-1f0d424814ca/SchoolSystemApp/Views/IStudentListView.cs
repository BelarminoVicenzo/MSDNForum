using System.Collections.Generic;
using SchoolSystemApp.Models;

namespace SchoolSystemApp.Views
{
    internal interface IStudentListView
    {
        List<StudentList> StudentDataSource { get; set; }
    }
}
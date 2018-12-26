using System.Collections.Generic;
using SchoolSystemApp.Models;

namespace SchoolSystemApp.Views
{
    internal interface IStudentVerificationView
    {
        List<StudentVerification> DataSource { get; set; }
    }
}
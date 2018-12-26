using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolSystemApp.Models;

namespace SchoolSystemApp.Views
{
    public partial class StudentVerificationView : Form, IStudentVerificationView
    {
        private readonly Prestenters.StudentVerificationPresenter presenter;
        public StudentVerificationView()
        {
            InitializeComponent();
            presenter = new Prestenters.StudentVerificationPresenter(this);
        }

        List<StudentVerification> IStudentVerificationView.DataSource
        {
            get => dataGridView1.DataSource as List<StudentVerification>;
            set => dataGridView1.DataSource = value;
        }
    }
}

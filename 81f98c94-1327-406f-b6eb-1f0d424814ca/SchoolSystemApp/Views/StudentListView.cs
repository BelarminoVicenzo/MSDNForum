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
    public partial class StudentListView : Form, IStudentListView
    {
        private readonly Prestenters.StudentListPresenter presenter;
        public StudentListView()
        {
            presenter = new Prestenters.StudentListPresenter(this);
            InitializeComponent();
        }

        List<StudentList> IStudentListView.StudentDataSource
        {
            get => dataGridView1.DataSource as List<StudentList>;
            set => dataGridView1.DataSource = value;
        }

        private void showStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            presenter.LoadStudents();
        }

        private void studiumVerificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            presenter.Verify();
        }
    }
}

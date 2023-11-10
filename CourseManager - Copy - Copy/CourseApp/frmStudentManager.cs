using BussinessObject;
using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseApp
{
    public partial class frmStudentManager : Form
    {
        CourseDB db = new CourseDB();
        public frmStudentManager()
        {
            InitializeComponent();
        }


        public IEnumerable<Students> GetAllStudents()
        {
            return StudentDAO.Instance.GetAllStudents();
        }


        private void frmStudentManager_Load(object sender, EventArgs e)
        {
            LoadAll();
        }

        public void LoadAll()
        {
            var stu = db.Students.ToList();

            var list = GetAllStudents();
            var cate = db.Courses.ToList();
            var join = db.Entrollments.ToList();



            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = join;
            dgvStudents.DataSource = bindingSource;



            //dgvStudents.Columns["StudentName"].Visible = false;





            cmbCate.DataSource = cate;
            cmbStudent.DataSource = stu;

            cmbCate.ValueMember = "CourseName";
            cmbStudent.ValueMember = "StudentName";
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            //using (CourseDB db = new CourseDB())
            //{
            //    Students students = new Students()
            //    {
            //        StudentName = "hoang",
            //        Address = "vn",
            //        Status = true
            //    };

            //    db.Students.Add(students);
            //    db.SaveChanges();
            //    LoadAll();

            //}
            //using (CourseDB db = new CourseDB())
            //{
            //    Courses course = new Courses
            //    {
            //        CourseName = "lap trinh",
            //        Status = true,

            //    };
            //    db.Courses.Add(course);
            //    db.SaveChanges();
            //    LoadAll();
            //}

            Enrollments enrollments = new Enrollments()
            {
                Course = (Courses)cmbCate.SelectedItem,
                Student = (Students)cmbStudent.SelectedItem,
                DateUpdate = DateTime.Now,
            };
            db.Entrollments.Add(enrollments);
            db.SaveChanges();
            LoadAll();

        }

        private void cmbCate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show(checkBox1.Checked + "");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = dgvStudents.CurrentCell.RowIndex;
            var dummy = (Enrollments)dgvStudents.Rows[index].DataBoundItem;
            db.Entrollments.Remove(dummy);
            db.SaveChanges();
            LoadAll();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int index = dgvStudents.CurrentCell.RowIndex;
            var dummy = (Enrollments)dgvStudents.Rows[index].DataBoundItem;
            dummy.Student.StudentName = "hoang hih";
            db.Entrollments.Update(dummy);
            db.SaveChanges();
            LoadAll();
        }
    }
}

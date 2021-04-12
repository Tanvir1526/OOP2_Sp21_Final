using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace CourseForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string cname = tbCname.Text;
            string ccode = tbCcode.Text;

            string connstring = @"Server=desktop-r1kif9b\sqlexpress;Database=Course;User Id=sa; Password=Atan1526!";
            SqlConnection conn = new SqlConnection(connstring);

            conn.Open();
            string qurey = String.Format("insert into courses values ('{0}','{1}')",cname,ccode);

            try
            {
                SqlCommand cmd = new SqlCommand(qurey, conn);
                int r = cmd.ExecuteNonQuery();
                if (r > 0)
                {
                    MessageBox.Show("Course Inserted");
                }
                else
                {
                    MessageBox.Show("Failed to Course Inserted");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn.Close();
            var courses = GetAllCourses();
            DtCourses.DataSource = courses;

        }

        private void LoadData_Click(object sender, EventArgs e)
        {
            var courses = GetAllCourses();
            DtCourses.DataSource = courses;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        List<Course>GetAllCourses()
        {
            string connstring = @"Server=desktop-r1kif9b\sqlexpress;Database=Course;User Id=sa; Password=Atan1526!";
            SqlConnection conn = new SqlConnection(connstring);

            List<Course> courses = new List<Course>();

            conn.Open();
            string qurey = "select * from courses";

            try
            {
                SqlCommand cmd = new SqlCommand(qurey, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Course c = new Course();
                    c.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                    c.CourseName = reader.GetString(reader.GetOrdinal("CourseName"));
                    c.CourseCode = reader.GetString(reader.GetOrdinal("CourseCode"));
                    courses.Add(c);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn.Close();
            return courses;
        }
    }
}

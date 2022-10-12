using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_122_F23_Lecture_7_WinForms
{
    public partial class Form1 : Form
    {
        List<Course> courses = new List<Course>();
        
        public Form1()
        {
            InitializeComponent();

        } // Form 1

        // Method that runs when button is clicked
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            // MessageBox - Pop up that takes a string
            string courseName = tbCourseName.Text;
            string courseId = tbCourseId.Text;
            string roomNum = tbCourseRoomNum.Text;
            string student = tbCourseStudent.Text;
            string teacher = tbCourseTeacher.Text;

            Course c = new Course(
                courseName,
                courseId,
                roomNum,
                teacher,
                student
                );

            courses.Add(c);
          

            DisplayCourses(courses);

        } // btnDisplay_Click

        public void DisplayCourses(List<Course> courses)
        {
            rtbDisplay.Text = "";

            foreach (Course course in courses)
            {
                string displayMessage = $"Course Name: {course.Name}" +
                 $"\nCourse ID: {course.CourseId}" +
                 $"\nRoom Number: {course.RoomNumber}" +
                 $"\nStudent: {course.Student}" +
                 $"\nTeacher: {course.Teacher}";

                rtbDisplay.Text += displayMessage;

                rtbDisplay.Text += "\n\n";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        // Buttons







        // TextBoxes
        // Rich Text Boxes

        // Labels


    } // class

} // namespace

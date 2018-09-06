using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace LearningPlatform
{
    public static class Database
    {
        private static Dictionary<string,Teacher> teachers; // stores all the teachers, lets you find them by just the email
        private static Dictionary<string, Student> students; // stores all the students, lets you find them by just the student ID

        public static bool isTeacher;
        public static Teacher currentTeacher;
        public static Student currentStudent;

        static Database()
        {
            teachers = new Dictionary<string, Teacher>(); // Create static Dictionary in static constructor to properly save values
            students = new Dictionary<string, Student>();
        }

        public static void createFiles() // These methods make sure all Data files exists
        {

            string fileName = String.Format(@"{0}\TeacherLogins.txt", Application.StartupPath); // Creates a filepath for data file, replace "Logins" with desired filename

            

            if(!File.Exists(fileName)) // Checks if the file exists
                File.Create(fileName); // If it does not exist, make it
            else
            {
                // TODO: Read from the file into the Database
            }

            fileName = String.Format(@"{0}\StudentLogins.txt", Application.StartupPath);
            if (!File.Exists(fileName)) 
                File.Create(fileName);
            else
            {
                // TODO: Read from the file into the Database
            }
        }

        public static bool addTeacher(string _email, string _pass, string _fName, string _lName)
        {
            string fileName = String.Format(@"{0}\TeacherLogins.txt", Application.StartupPath);
            
            if (teachers.ContainsKey(_email)) // If the that email is already registered, let the user know
                return false;
            // Otherwise register the teacher
            Teacher newTeacher = new Teacher(_email, _pass, _fName, _lName); // Creates a teacher
            teachers.Add(_email, newTeacher); // Adds the teacher to the List of teachers
            // Now Store in file
            File.AppendAllText(fileName, newTeacher.encoded()+"|");
            
            return true;
        }

        public static bool checkTeacherLogin(string _email, string _pass) // Checks if email and password are correct
        {
            return (teachers.ContainsKey(_email) && teachers[_email].password == _pass);
            
        }
        public static bool checkStudentLogin(string _id, string _pass) // Checks if id and password are correct
        {
            return (students.ContainsKey(_id) && students[_id].password == _pass);
        }
        public static void setTeacher(string _email) // Sets which teacher is logged in
        {
            isTeacher = true;
            currentTeacher = teachers[_email];
        }
        public static void setStudent(string _id) // Sets which student is logged in
        {
            isTeacher = false;
            currentStudent = students[_id];
        }
    }
}

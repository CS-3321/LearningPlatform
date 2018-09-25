using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningPlatform
{
    public class SchoolClass
    {
        public string className;
        public string classID;
        public User teacher; // stores the teacher
        public List<User> students; // Stores all students
        public Dictionary<User, Grade> grades; // lets you find a grade based on a user (REMINDER: Database class is storing current user!)

        public SchoolClass(User t) // When making a class, only a teacher is needed at the start
        {
            teacher = t;
            students = new List<User>();
            grades = new Dictionary<User, Grade>();
        }

        public SchoolClass(string info) // This constructor should be used for loading a SchoolClass
        {
            // Info example "CS-3321&107298&jones@gmail.com&993251!60^45^99^43^88#993251!60^45^99^43^88"

            // Parse the class names.
            info = className;
            string[] allInfo = info.Split('&');
            className = allInfo[0];
            classID = allInfo[1];
            teacher = Database.users[allInfo[2]];
            // all students in allInfo[3]
            // Parse the students.
          //  grades.Add(USER HERE, new Grade(GRADE STRING HERE));
        }

        public int[] getGrades(User _user) // returns an array of intergers that represent a user's grades
        {
            if(grades.ContainsKey(_user))
                return grades[_user].AllGrades();
            return new int[0]; // returns empty array if user was not found
        }

    }
}

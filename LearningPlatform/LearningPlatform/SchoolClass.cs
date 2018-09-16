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

        public SchoolClass() // This constructor should be used for loading a SchoolClass
        {
            // Read the contents in UserLogins into a string variable.
            string usersText = System.IO.File.ReadAllText(@"C:\Users\Public\TestFolder\UserLogins.txt");
           
            // Create a User variable and store all the users' info in the user list.
            User users;
            users.Add(new User(usersText));
            List<User>(usersText);
        }

        public int[] getGrades(User _user) // returns an array of intergers that represent a user's grades
        {
            if(grades.ContainsKey(_user))
                return grades[_user].AllGrades();
            return new int[0]; // returns empty array if user was not found
        }

    }
}

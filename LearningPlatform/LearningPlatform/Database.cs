using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningPlatform
{
    public static class Database
    {
        private static Dictionary<string,User> users; // stores all the teachers, lets you find them by just the email
        private static Dictionary<string, SchoolClass> classes; // stores all classes, find them with class name
        private static List<string> classNames; // stores all the names of classes (Due to each class having it's own file)

        public static bool isTeacher; // Keeps track of if the current user is a teacher
        public static User currentUser; // Keeps track of the curreent user logged in
        public static List<SchoolClass> currentClasses; // When user logs in, find all the classes they are in, and store them here

        public static string userFileName;
        public static string classFileName;



        static Database()
        {
            users = new Dictionary<string, User>(); // Create static Dictionary in static constructor to properly save values
            classes = new Dictionary<string, SchoolClass>();
            userFileName = String.Format(@"{0}\UserLogins.txt", Application.StartupPath); // Creates a filepath for User data file
            classFileName = String.Format(@"{0}\ClassNames.txt", Application.StartupPath); // Creates a filepath for Class data file
        }

        public static void CreateFiles() // These methods make sure all Data files exists
        {
            if(!File.Exists(userFileName)) // Checks if the User file exists
                File.Create(userFileName); // If it does not exist, make it
            else
            {
                string usersText = File.ReadAllText(userFileName); // Read in all data
                string[] _allUsers = usersText.Split('|'); // Split the data properly, store in an array
                User _tempUser = null; // Blank temp user
                foreach (string _userInfo in _allUsers) // Go through all the info
                {
                    _tempUser = new User(_userInfo); // Create the new User
                    users.Add(_tempUser.username, _tempUser); // Add the user to the Dictonary(A list that stores 2 things together) name, User
                }
            }

            if (!File.Exists(classFileName)) // Checks if the Class file exists
                File.Create(classFileName); // If it does not exist, make it
            else
            {
                string classText = File.ReadAllText(classFileName); // Read in all data
                string[] _allClasses = classText.Split('|'); // Split the data properly, store in an array
                classNames = new List<string>(_allClasses); // Since we just need to turn an array into a list, we can just pass the array
                                                            // when creating the List.
            }

            // TODO: Read in all class files based on class names in the classNames List, store them in the classes Dictonary
        }

        public static bool AddTeacher(string _user, string _pass, string _fName, string _lName)
        {
            if (users.ContainsKey(_user)) // If the that username is already registered, let the user know
                return false;
            // Otherwise register the teacher
            User newUser = new User(_user, _pass, _fName, _lName, "", true); // Creates a teacher with no classes
            users.Add(_user, newUser); // Adds the teacher to the List of users
            // Now Store in file
            File.AppendAllText(userFileName, newUser.Encoded()+"|");
            
            return true;
        }

        public static bool CheckTeacherLogin(string _user, string _pass) // Checks if email and password are correct
        {
            // checks if user exists, if they do, checks if their password is correct, if it is, checks if they are a teacher
            return (users.ContainsKey(_user) && users[_user].password == _pass && users[_user].isTeacher); 
            
        }
        public static bool CheckStudentLogin(string _user, string _pass) // Checks if id and password are correct
        {
            // checks if user exists, if they do, checks if their password is correct, if it is, checks if they are a student
            return (users.ContainsKey(_user) && users[_user].password == _pass && !users[_user].isTeacher);
        }
        public static void SetTeacher(string _user) // Sets which teacher is logged in
        {
            isTeacher = true;
            currentUser = users[_user];
        }
        public static void SetStudent(string _user) // Sets which student is logged in
        {
            isTeacher = false;
            currentUser = users[_user];
        }
    }
}

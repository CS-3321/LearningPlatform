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
        public static Dictionary<string,User> users; // stores all the teachers, lets you find them by just the email
        public static Dictionary<string, SchoolClass> classes; // stores all classes, find them with class ID
        public static List<string> classNames; // stores all the names of classes (Due to each class having it's own file)

        public static bool isTeacher; // Keeps track of if the current user is a teacher
        public static User currentUser; // Keeps track of the curreent user logged in
        public static List<SchoolClass> currentClasses; // When user logs in, find all the classes they are in, and store them here

        public static string userFileName;
        public static string classFileName;



        static Database()
        {
            users = new Dictionary<string, User>(); // Create static Dictionary in static constructor to properly save values
            classes = new Dictionary<string, SchoolClass>(); // Empty dictonary
            userFileName = String.Format(@"{0}\UserLogins.txt", Application.StartupPath); // Creates a filepath for User data file
            classFileName = String.Format(@"{0}\ClassNames.txt", Application.StartupPath); // Creates a filepath for Class data file
            currentClasses = new List<SchoolClass>(); // Empty list
        }

        public static void CreateFiles() // These methods make sure all Data files exists
        {
            if(!File.Exists(userFileName)) // Checks if the User file exists
                File.Create(userFileName); // If it does not exist, make it
            else
            {
                string usersText = File.ReadAllText(userFileName); // Read in all data
                if (usersText.Contains('|')) // Makes sure there is atleast one user
                {
                    usersText = usersText.Substring(0, usersText.Length - 1); // gets rid of the last '|' to avoid empty user
                    string[] _allUsers = usersText.Split('|'); // Split the data properly, store in an array
                    User _tempUser = null; // Blank temp user
                    foreach (string _userInfo in _allUsers) // Go through all the info
                    {
                        _tempUser = new User(_userInfo); // Create the new User
                        if(!users.ContainsKey(_tempUser.username))
                          users.Add(_tempUser.username, _tempUser); // Add the user to the Dictonary(A list that stores 2 things together) name, User
                    }
                }
                
            }

            if (!File.Exists(classFileName)) // Checks if the Class file exists
                File.Create(classFileName); // If it does not exist, make it
            else
            {

                string classText = File.ReadAllText(classFileName); // Read in all data
                if (classText.Contains('|')) // Makes sure there is atleast one class
                {
                    classText = classText.Substring(0, classText.Length - 1); // gets rid of the last '|' to avoid empty class
                    string[] _allClasses = classText.Split('|'); // Split the data properly, store in an array
                    classNames = new List<string>(_allClasses); // Since we just need to turn an array into a list, we can just pass the array
                                                                // when creating the List.
                }

            }

            // Read in all SchoolClass's info.
            string classText = File.ReadAllText(classFileName);
            string[] _classNames = classText.Split('|');
            SchoolClass(classText);
            
            for (int a = 0; a < _classNames.Length; a++
                 {
                     classes.Add(Database.classes[_classNames[a]]);
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

        public static void SetCurrentClasses() // Gets the classes the user is in, and fills the list currentClasses
        {
            string _classes = Database.currentUser.classes; // Get string of all classes
            if(_classes.Length != 0)
            {
                _classes = _classes.Substring(0, _classes.Length - 1); // Remove last @ symbol

                string[] allClasses = _classes.Split('@'); // Make an array of all classes the student is in
                for (int i = 0; i < allClasses.Length; i++) // Go through all classes
                {
                    currentClasses.Add(Database.classes[allClasses[i]]); // Add each class the student is in to the currentClasses list
                }
            }
        }
    }
}

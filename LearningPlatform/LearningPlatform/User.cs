using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningPlatform
{

    public class User // Replaced Student and Teacher class
    {
        public string username; // can be either an student ID or a teacher email
        public string password;
        public string firstName;
        public string lastName;
        public string classes;
        public bool isTeacher; // True or False value based on if the user is a teacher or not

        public User(string u, string p, string f, string l, string c, bool t) // When you make a student, you can pass all the info to store
        {
            username = u;
            password = p;
            firstName = f;
            lastName = l;
            classes = c;
            isTeacher = t;
        }
        public User(string info) // Takes all four arguments in 1 string
        {
            string[] allInfo = info.Split('&'); // splits the string and stores it in an array
            username = allInfo[0];
            password = allInfo[1];
            firstName = allInfo[2];
            lastName = allInfo[3];
            classes = allInfo[4];
            isTeacher = allInfo[5].Equals("true"); // Turns the string "True" or the string "False" into the actual bool value
        }
        public string Encoded() // stores all data in a single string
        {
            return username + "&" + password + "&" + firstName + "&" + lastName + "&" + classes + "&" + isTeacher.ToString();
        }
    }
}
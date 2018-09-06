using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningPlatform
{
    public class Grade // Currently stores grades as integers, can change to float, must round to 2 decimals if that change is made
    {
        public List<int> grades;
        public Grade()
        {
            grades = new List<int>(); // create empty list
        }
        public Grade(string _grades)
        {
            grades = new List<int>();
            string[] tempGrades = _grades.Split('^'); // takes a single string with all grades, turns it into an array of strings
            foreach (string grade in tempGrades) // goes through the array
            {
                grades.Add(Int32.Parse(grade)); // Turns the string into an int and adds it to the grade List
            }
        }
        
        public void AddGrade(int _grade) // Adds a grade to list
        {
            grades.Add(_grade);
        }
        public void AddGrade(string _grade) // Changes grade from string to int, then adds to the list
        {
            grades.Add(Int32.Parse(_grade));
        }

        public int[] AllGrades()
        {
            return grades.ToArray(); // returns the list as an array for easy reading and use
        }

        public int Average() // returns a rounded version of the grade average
        {
            return (int)Math.Round(grades.Average()); // gets average, rounds it, then turns it back into an integer
        }

        public string Encode()
        {
            string gradeString = "";
            foreach (int grade in grades)
            {
                gradeString += grade.ToString() + "^"; // Adds every grade to a string and seperates it by the symbol ^
            }
            return gradeString;
        }
    }
}

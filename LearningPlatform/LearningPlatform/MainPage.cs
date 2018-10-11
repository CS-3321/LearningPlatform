using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ambiance;

namespace LearningPlatform
{
    public partial class MainPage : Form
    {

        List<TabPage> allTabs; // Stores all tabs

        public MainPage() // Constructor function, gets called when the user logins successfully
        {
            InitializeComponent(); // Makes the form
            allTabs = new List<TabPage>(); // Creates empty list
            Database.SetCurrentClasses(); // Sets up the current classes the student or teacher is in
            UpdateUI(); // Make the UI unique for each student or teacher
        }

        private void exit_button_Click(object sender, EventArgs e) // Depreciated
        {
            Application.Exit(); // Exits when exit button is clicked
        }

        public void UpdateUI()
        {
            ChangeForTeacher();
            AddTabs();
        }

        public void ChangeForTeacher()
        {
            if (Database.isTeacher)
            {
                classTabs.Size = new System.Drawing.Size(921, 427);
                createClassButton.Enabled = true;
                createClassButton.Visible = true;
                addStudentButton.Enabled = true;
                addStudentButton.Visible = true;
            }
            else
            {
                classTabs.Size = new System.Drawing.Size(921, 487);
                createClassButton.Enabled = false;
                createClassButton.Visible = false;
                addStudentButton.Enabled = false;
                addStudentButton.Visible = false;
            }
        }

        public void AddTabs()
        {
            int count = 0;

            #region testing
            SchoolClass tempClass = new SchoolClass("CS_2410", "930873", Database.currentUser);
            Database.currentClasses.Add(tempClass);
            Database.classes.Add(tempClass.classID, tempClass);

            tempClass = new SchoolClass("MATH_3520", "171120", Database.currentUser);
            Database.currentClasses.Add(tempClass);
            Database.classes.Add(tempClass.classID, tempClass);

            for (int i = 0; i < 5; i++)
            {
                Database.currentClasses[0].students.Add(new User("none", "none", "First"+i, "Last"+i, "", false));
                Database.currentClasses[1].students.Add(new User("none", "none", "First2" + i, "Last2" + i, "", false));
            }
            #endregion

            foreach (SchoolClass classTab in Database.currentClasses) // WIP: Adding tabs equal to number of classes
            {
                AddTab(classTab, count); // Add tab, only info needed is a SchoolClass and the index
                count++; // Increase index after every tab
            }
        }


        public void AddTab(SchoolClass classTab, int index) // This method adds a tab to the main page based on the info of a SchoolClass
        {
            TabPage tab = new System.Windows.Forms.TabPage // Create a new tab with className
            {
                Text = classTab.className,
                Name = classTab.classID,
                Size = new System.Drawing.Size(256, 214),
                TabIndex = index
            };

            allTabs.Add(tab); // Store all tabs in a list
            classTabs.Controls.Add(tab); // Add tab to display
            Ambiance_HeaderLabel teacherLabel = new Ambiance_HeaderLabel
            {
                AutoSize = true,
                Location = new System.Drawing.Point(16, 7),
                Name = "teacherLabel",
             //   Font = new Font("Segoe UI", 12.0f, FontStyle.Bold),
                Size = new System.Drawing.Size(43, 90),
                Text = ("Teacher : " + Database.currentClasses[index].teacher.firstName + " " + Database.currentClasses[index].teacher.lastName)
            };
            Ambiance_Label classIDLabel = new Ambiance_Label
            {
                AutoSize = true,
                Location = new System.Drawing.Point(16, 27),
                Name = "classIDLabel",
            //    Font = new Font("Segoe UI", 12.0f, FontStyle.Regular),
                Size = new System.Drawing.Size(43, 13),
                Text = ("Class ID  : " + Database.currentClasses[index].classID)
            };
            
            tab.Controls.Add(teacherLabel);
            tab.Controls.Add(classIDLabel);

            if (Database.isTeacher) // If user is a teacher, add these elements to tabs
            {
                Ambiance_ComboBox studentBox = new Ambiance_ComboBox
                {
                    Location = new System.Drawing.Point(700, 10),
                    Name = "studentBox",
                    Size = new System.Drawing.Size(204, 26)
                };
                Ambiance_HeaderLabel studentLabel = new Ambiance_HeaderLabel
                {
                    AutoSize = true,
                    Location = new System.Drawing.Point(565, 13),
                    Name = "studentLabel",
                    //    Font = new Font("Segoe UI", 12.0f, FontStyle.Regular),
                    Size = new System.Drawing.Size(129, 20),
                    Text = ("Current Student :")
                };
                Ambiance_HeaderLabel selectStudentLabel = new Ambiance_HeaderLabel
                {
                    AutoSize = true,
                    Location = new System.Drawing.Point(72, 180),
                    Name = "selectStudentLabel",
                    Font = new Font("Segoe UI", 32.0f, FontStyle.Bold),
                    Size = new System.Drawing.Size(773, 59),
                    Text = ("Select a student to view their grades.")
                };
                foreach (User userInClass in classTab.students)
                {
                    studentBox.Items.Add(userInClass.firstName + " " + userInClass.lastName);
                }
                studentBox.SelectedIndexChanged += new EventHandler(DynamicComboBox_OnChange);

                tab.Controls.Add(studentLabel);
                tab.Controls.Add(studentBox);
                tab.Controls.Add(selectStudentLabel);
            }
            else // If the user is a student, add these elements
            {
                ShowInfoStudent(tab, classTab, Database.currentUser);
            }
            
        }

        private void DynamicComboBox_OnChange(object sender, EventArgs e) // Handles when the student combobox is changed
        {
            // WIP change labels based on student clicked
            TabPage tab = (TabPage)((ComboBox)sender).Parent; // Gets the current Tab that we are on
            SchoolClass currentClass = Database.classes[((ComboBox)sender).Parent.Name]; // Gets the current class we are on
            User currentUser = currentClass.students[((ComboBox)sender).SelectedIndex]; // Gets the user that was selected
            ShowInfoTeacher(tab, currentClass, currentUser);
        }

        private void ShowInfoTeacher(TabPage tab, SchoolClass currentClass, User currentUser) // Shows grades for particular student (Teacher only Method)
        {
            if(tab.Controls.ContainsKey("selectStudentLabel"))
                tab.Controls.Remove(tab.Controls.Find("selectStudentLabel", false)[0]);
            Ambiance_Label studentNameLabel = new Ambiance_Label
            {
                AutoSize = true,
                Location = new System.Drawing.Point(326, 16),
                Name = "studentNameLabel",
                Size = new System.Drawing.Size(185, 20),
                Text = ("Student Name : " + currentUser.firstName + " " + currentUser.lastName)
            };
            Ambiance_Label studentIDLabel = new Ambiance_Label
            {
                AutoSize = true,
                Location = new System.Drawing.Point(351, 56),
                Name = "studentIDLabel",
                Size = new System.Drawing.Size(138, 20),
                Text = ("Student ID : " + currentUser.username)
            };
            tab.Controls.Add(studentNameLabel);
            tab.Controls.Add(studentIDLabel);
        }
        private void ShowInfoStudent(TabPage tab, SchoolClass currentClass, User currentUser)
        {

        }

        private void TESTERBUTTON_Click(object sender, EventArgs e)
        {
            Database.isTeacher = !Database.isTeacher;
            ChangeForTeacher();
        } // For testing purposes, changes from student to teacher.

    }
}

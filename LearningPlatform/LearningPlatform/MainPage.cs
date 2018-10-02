using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningPlatform
{
    public partial class MainPage : Form
    {

        List<TabPage> allTabs;

        public MainPage()
        {
            InitializeComponent();
            allTabs = new List<TabPage>();
            UpdateUI();
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
            TabPage tab = null;
            int count = 0;

            #region testing
            Database.currentClasses.Add(new SchoolClass("CS_2410", "930873", Database.currentUser));
            Database.currentClasses.Add(new SchoolClass("MATH_3520", "171120", Database.currentUser));
            #endregion

            foreach (SchoolClass classTab in Database.currentClasses) // WIP: Adding tabs equal to number of classes
            {
                tab = new System.Windows.Forms.TabPage // Create a new tab with className
                {
                    Text = classTab.className,
                    Size = new System.Drawing.Size(256, 214),
                    TabIndex = count
                };
                
                allTabs.Add(tab); // Store all tabs in a list
                classTabs.Controls.Add(tab); // Add tab to display
                Label teacherLabel = new Label
                {
                    AutoSize = true,
                    Location = new System.Drawing.Point(16, 7),
                    Name = "teacherLabel" + count,
                    Font = new Font("Segoe UI", 12.0f, FontStyle.Bold),
                    Size = new System.Drawing.Size(43, 90),
                    Text = ("Teacher : " + Database.currentClasses[count].teacher.firstName + " " + Database.currentClasses[count].teacher.lastName)
                };
                Label classIDLabel = new Label
                {
                    AutoSize = true,
                    Location = new System.Drawing.Point(16, 27),
                    Name = "teacherLabel" + count,
                    Font = new Font("Segoe UI", 12.0f, FontStyle.Regular),
                    Size = new System.Drawing.Size(43, 13),
                    Text = ("Class ID  : " + Database.currentClasses[count].classID)
                };
                tab.Controls.Add(teacherLabel);
                tab.Controls.Add(classIDLabel);
                count++;
            }
        }
        

        private void TESTERBUTTON_Click(object sender, EventArgs e)
        {
            Database.isTeacher = !Database.isTeacher;
            ChangeForTeacher();
        }
    }
}

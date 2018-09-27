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
        public MainPage()
        {
            InitializeComponent();

            updateUI();
        }

        private void exit_button_Click(object sender, EventArgs e) // Depreciated
        {
            Application.Exit(); // Exits when exit button is clicked
        }

        public void updateUI()
        {
            changeForTeacher();
            addTabs();
        }

        public void changeForTeacher()
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

        public void addTabs()
        {
            TabPage temp = null;
            int count = 0;
            foreach (SchoolClass classTab in Database.currentClasses) // WIP: Adding tabs equal to number of classes
            {
                temp = new System.Windows.Forms.TabPage();
                temp.Text = classTab.className;
                temp.Size = new System.Drawing.Size(256, 214);
                temp.TabIndex = count;
                count++;
                classTabs.Controls.Add(temp);
            }
        }

        private void TESTERBUTTON_Click(object sender, EventArgs e)
        {
            Database.isTeacher = !Database.isTeacher;
            changeForTeacher();
        }
    }
}

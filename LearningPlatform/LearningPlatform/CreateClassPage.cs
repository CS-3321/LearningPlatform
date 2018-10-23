﻿using System;
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
    public partial class CreateClassPage : Form
    {
        public CreateClassPage()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateClassButton_Click(object sender, EventArgs e)
        {
            if(Database.AddSchoolClass("TempName", "TempID"))
            {
                // tell the user it was created properly
            }
            else
            {
                // tell the user it wasnt
            }

            this.Close();
        }
    }
}

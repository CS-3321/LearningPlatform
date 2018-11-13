namespace LearningPlatform
{
    partial class MainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.ambiance_ThemeContainer1 = new Ambiance.Ambiance_ThemeContainer();
            this.addStudentButton = new Ambiance.Ambiance_Button_1();
            this.createClassButton = new Ambiance.Ambiance_Button_2();
            this.classTabs = new Ambiance.Ambiance_TabControl();
            this.testTab = new System.Windows.Forms.TabPage();
            this.ambiance_Label4 = new Ambiance.Ambiance_Label();
            this.ambiance_Button_11 = new Ambiance.Ambiance_Button_1();
            this.ambiance_Panel1 = new Ambiance.Ambiance_Panel();
            this.ambiance_Label5 = new Ambiance.Ambiance_Label();
            this.ambiance_Separator2 = new Ambiance.Ambiance_Separator();
            this.ambiance_TextBox2 = new Ambiance.Ambiance_TextBox();
            this.ambiance_Label2 = new Ambiance.Ambiance_Label();
            this.ambiance_Separator1 = new Ambiance.Ambiance_Separator();
            this.ambiance_TextBox1 = new Ambiance.Ambiance_TextBox();
            this.ambiance_Button_21 = new Ambiance.Ambiance_Button_2();
            this.ambiance_Label3 = new Ambiance.Ambiance_Label();
            this.ambiance_Label1 = new Ambiance.Ambiance_Label();
            this.ambiance_HeaderLabel1 = new Ambiance.Ambiance_HeaderLabel();
            this.ambiance_ComboBox1 = new Ambiance.Ambiance_ComboBox();
            this.ControlBox = new Ambiance.Ambiance_ControlBox();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.ambiance_ThemeContainer1.SuspendLayout();
            this.classTabs.SuspendLayout();
            this.testTab.SuspendLayout();
            this.ambiance_Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // ambiance_ThemeContainer1
            // 
            this.ambiance_ThemeContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.ambiance_ThemeContainer1.Controls.Add(this.addStudentButton);
            this.ambiance_ThemeContainer1.Controls.Add(this.createClassButton);
            this.ambiance_ThemeContainer1.Controls.Add(this.classTabs);
            this.ambiance_ThemeContainer1.Controls.Add(this.ControlBox);
            this.ambiance_ThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ambiance_ThemeContainer1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ambiance_ThemeContainer1.Location = new System.Drawing.Point(0, 0);
            this.ambiance_ThemeContainer1.Name = "ambiance_ThemeContainer1";
            this.ambiance_ThemeContainer1.Padding = new System.Windows.Forms.Padding(20, 56, 20, 16);
            this.ambiance_ThemeContainer1.RoundCorners = true;
            this.ambiance_ThemeContainer1.Sizable = true;
            this.ambiance_ThemeContainer1.Size = new System.Drawing.Size(967, 565);
            this.ambiance_ThemeContainer1.SmartBounds = true;
            this.ambiance_ThemeContainer1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.ambiance_ThemeContainer1.TabIndex = 0;
            this.ambiance_ThemeContainer1.Text = "Generic Learning Platform";
            // 
            // addStudentButton
            // 
            this.addStudentButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addStudentButton.BackColor = System.Drawing.Color.Transparent;
            this.addStudentButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.addStudentButton.Image = null;
            this.addStudentButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addStudentButton.Location = new System.Drawing.Point(477, 505);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(177, 30);
            this.addStudentButton.TabIndex = 6;
            this.addStudentButton.Text = "Add Student";
            this.addStudentButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click);
            // 
            // createClassButton
            // 
            this.createClassButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.createClassButton.BackColor = System.Drawing.Color.Transparent;
            this.createClassButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.createClassButton.Image = null;
            this.createClassButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createClassButton.Location = new System.Drawing.Point(253, 505);
            this.createClassButton.Name = "createClassButton";
            this.createClassButton.Size = new System.Drawing.Size(177, 30);
            this.createClassButton.TabIndex = 5;
            this.createClassButton.Text = "Create Class";
            this.createClassButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.createClassButton.Click += new System.EventHandler(this.createClassButton_Click);
            // 
            // classTabs
            // 
            this.classTabs.Controls.Add(this.testTab);
            this.classTabs.ItemSize = new System.Drawing.Size(80, 24);
            this.classTabs.Location = new System.Drawing.Point(23, 59);
            this.classTabs.Name = "classTabs";
            this.classTabs.SelectedIndex = 0;
            this.classTabs.Size = new System.Drawing.Size(921, 427);
            this.classTabs.TabIndex = 0;
            // 
            // testTab
            // 
            this.testTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.testTab.Controls.Add(this.ambiance_Label4);
            this.testTab.Controls.Add(this.ambiance_Button_11);
            this.testTab.Controls.Add(this.ambiance_Panel1);
            this.testTab.Controls.Add(this.ambiance_Button_21);
            this.testTab.Controls.Add(this.ambiance_Label3);
            this.testTab.Controls.Add(this.ambiance_Label1);
            this.testTab.Controls.Add(this.ambiance_HeaderLabel1);
            this.testTab.Controls.Add(this.ambiance_ComboBox1);
            this.testTab.Location = new System.Drawing.Point(4, 28);
            this.testTab.Name = "testTab";
            this.testTab.Padding = new System.Windows.Forms.Padding(3);
            this.testTab.Size = new System.Drawing.Size(913, 395);
            this.testTab.TabIndex = 0;
            this.testTab.Text = "Test Tab";
            // 
            // ambiance_Label4
            // 
            this.ambiance_Label4.AutoSize = true;
            this.ambiance_Label4.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label4.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ambiance_Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_Label4.Location = new System.Drawing.Point(395, 95);
            this.ambiance_Label4.Name = "ambiance_Label4";
            this.ambiance_Label4.Size = new System.Drawing.Size(74, 20);
            this.ambiance_Label4.TabIndex = 13;
            this.ambiance_Label4.Text = "GPA : 4.00";
            // 
            // ambiance_Button_11
            // 
            this.ambiance_Button_11.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Button_11.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ambiance_Button_11.Image = null;
            this.ambiance_Button_11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ambiance_Button_11.Location = new System.Drawing.Point(593, 307);
            this.ambiance_Button_11.Name = "ambiance_Button_11";
            this.ambiance_Button_11.Size = new System.Drawing.Size(139, 30);
            this.ambiance_Button_11.TabIndex = 12;
            this.ambiance_Button_11.Text = "Add Test Score";
            this.ambiance_Button_11.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // ambiance_Panel1
            // 
            this.ambiance_Panel1.AutoScroll = true;
            this.ambiance_Panel1.BackColor = System.Drawing.Color.White;
            this.ambiance_Panel1.Controls.Add(this.ambiance_Label5);
            this.ambiance_Panel1.Controls.Add(this.ambiance_Separator2);
            this.ambiance_Panel1.Controls.Add(this.ambiance_TextBox2);
            this.ambiance_Panel1.Controls.Add(this.ambiance_Label2);
            this.ambiance_Panel1.Controls.Add(this.ambiance_Separator1);
            this.ambiance_Panel1.Controls.Add(this.ambiance_TextBox1);
            this.ambiance_Panel1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ambiance_Panel1.Location = new System.Drawing.Point(745, 56);
            this.ambiance_Panel1.Name = "ambiance_Panel1";
            this.ambiance_Panel1.Size = new System.Drawing.Size(148, 320);
            this.ambiance_Panel1.TabIndex = 11;
            this.ambiance_Panel1.Text = "ambiance_Panel1";
            // 
            // ambiance_Label5
            // 
            this.ambiance_Label5.AutoSize = true;
            this.ambiance_Label5.BackColor = System.Drawing.Color.White;
            this.ambiance_Label5.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ambiance_Label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_Label5.Location = new System.Drawing.Point(12, 60);
            this.ambiance_Label5.Name = "ambiance_Label5";
            this.ambiance_Label5.Size = new System.Drawing.Size(54, 20);
            this.ambiance_Label5.TabIndex = 11;
            this.ambiance_Label5.Text = "Test 2 :";
            // 
            // ambiance_Separator2
            // 
            this.ambiance_Separator2.BackColor = System.Drawing.Color.White;
            this.ambiance_Separator2.Location = new System.Drawing.Point(4, 90);
            this.ambiance_Separator2.Name = "ambiance_Separator2";
            this.ambiance_Separator2.Size = new System.Drawing.Size(139, 10);
            this.ambiance_Separator2.TabIndex = 12;
            this.ambiance_Separator2.Text = "ambiance_Separator2";
            // 
            // ambiance_TextBox2
            // 
            this.ambiance_TextBox2.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_TextBox2.Font = new System.Drawing.Font("Tahoma", 11F);
            this.ambiance_TextBox2.ForeColor = System.Drawing.Color.DimGray;
            this.ambiance_TextBox2.Location = new System.Drawing.Point(73, 57);
            this.ambiance_TextBox2.MaxLength = 3;
            this.ambiance_TextBox2.Multiline = false;
            this.ambiance_TextBox2.Name = "ambiance_TextBox2";
            this.ambiance_TextBox2.ReadOnly = false;
            this.ambiance_TextBox2.Size = new System.Drawing.Size(69, 28);
            this.ambiance_TextBox2.TabIndex = 13;
            this.ambiance_TextBox2.Text = "100";
            this.ambiance_TextBox2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.ambiance_TextBox2.UseSystemPasswordChar = false;
            // 
            // ambiance_Label2
            // 
            this.ambiance_Label2.AutoSize = true;
            this.ambiance_Label2.BackColor = System.Drawing.Color.White;
            this.ambiance_Label2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ambiance_Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_Label2.Location = new System.Drawing.Point(12, 12);
            this.ambiance_Label2.Name = "ambiance_Label2";
            this.ambiance_Label2.Size = new System.Drawing.Size(54, 20);
            this.ambiance_Label2.TabIndex = 8;
            this.ambiance_Label2.Text = "Test 1 :";
            // 
            // ambiance_Separator1
            // 
            this.ambiance_Separator1.BackColor = System.Drawing.Color.White;
            this.ambiance_Separator1.Location = new System.Drawing.Point(4, 42);
            this.ambiance_Separator1.Name = "ambiance_Separator1";
            this.ambiance_Separator1.Size = new System.Drawing.Size(139, 10);
            this.ambiance_Separator1.TabIndex = 9;
            this.ambiance_Separator1.Text = "ambiance_Separator1";
            // 
            // ambiance_TextBox1
            // 
            this.ambiance_TextBox1.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_TextBox1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.ambiance_TextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.ambiance_TextBox1.Location = new System.Drawing.Point(73, 9);
            this.ambiance_TextBox1.MaxLength = 3;
            this.ambiance_TextBox1.Multiline = false;
            this.ambiance_TextBox1.Name = "ambiance_TextBox1";
            this.ambiance_TextBox1.ReadOnly = false;
            this.ambiance_TextBox1.Size = new System.Drawing.Size(69, 28);
            this.ambiance_TextBox1.TabIndex = 10;
            this.ambiance_TextBox1.Text = "100";
            this.ambiance_TextBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.ambiance_TextBox1.UseSystemPasswordChar = false;
            // 
            // ambiance_Button_21
            // 
            this.ambiance_Button_21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ambiance_Button_21.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Button_21.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.ambiance_Button_21.Image = null;
            this.ambiance_Button_21.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ambiance_Button_21.Location = new System.Drawing.Point(593, 346);
            this.ambiance_Button_21.Name = "ambiance_Button_21";
            this.ambiance_Button_21.Size = new System.Drawing.Size(139, 30);
            this.ambiance_Button_21.TabIndex = 6;
            this.ambiance_Button_21.Text = "Commit Changes";
            this.ambiance_Button_21.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // ambiance_Label3
            // 
            this.ambiance_Label3.AutoSize = true;
            this.ambiance_Label3.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ambiance_Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_Label3.Location = new System.Drawing.Point(351, 56);
            this.ambiance_Label3.Name = "ambiance_Label3";
            this.ambiance_Label3.Size = new System.Drawing.Size(138, 20);
            this.ambiance_Label3.TabIndex = 4;
            this.ambiance_Label3.Text = "Student ID : 909183";
            // 
            // ambiance_Label1
            // 
            this.ambiance_Label1.AutoSize = true;
            this.ambiance_Label1.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ambiance_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_Label1.Location = new System.Drawing.Point(326, 16);
            this.ambiance_Label1.Name = "ambiance_Label1";
            this.ambiance_Label1.Size = new System.Drawing.Size(185, 20);
            this.ambiance_Label1.TabIndex = 2;
            this.ambiance_Label1.Text = "Student Name : Test Name";
            // 
            // ambiance_HeaderLabel1
            // 
            this.ambiance_HeaderLabel1.AutoSize = true;
            this.ambiance_HeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_HeaderLabel1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.ambiance_HeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_HeaderLabel1.Location = new System.Drawing.Point(565, 13);
            this.ambiance_HeaderLabel1.Name = "ambiance_HeaderLabel1";
            this.ambiance_HeaderLabel1.Size = new System.Drawing.Size(129, 20);
            this.ambiance_HeaderLabel1.TabIndex = 1;
            this.ambiance_HeaderLabel1.Text = "Current Student :";
            // 
            // ambiance_ComboBox1
            // 
            this.ambiance_ComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.ambiance_ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ambiance_ComboBox1.DropDownHeight = 100;
            this.ambiance_ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ambiance_ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ambiance_ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.ambiance_ComboBox1.FormattingEnabled = true;
            this.ambiance_ComboBox1.HoverSelectionColor = System.Drawing.Color.Empty;
            this.ambiance_ComboBox1.IntegralHeight = false;
            this.ambiance_ComboBox1.ItemHeight = 20;
            this.ambiance_ComboBox1.Items.AddRange(new object[] {
            "Test",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "Something Something"});
            this.ambiance_ComboBox1.Location = new System.Drawing.Point(700, 10);
            this.ambiance_ComboBox1.Name = "ambiance_ComboBox1";
            this.ambiance_ComboBox1.Size = new System.Drawing.Size(204, 26);
            this.ambiance_ComboBox1.StartIndex = 0;
            this.ambiance_ComboBox1.TabIndex = 0;
            // 
            // ControlBox
            // 
            this.ControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlBox.BackColor = System.Drawing.Color.Transparent;
            this.ControlBox.EnableMaximize = true;
            this.ControlBox.Font = new System.Drawing.Font("Marlett", 7F);
            this.ControlBox.Location = new System.Drawing.Point(5, 13);
            this.ControlBox.Name = "ControlBox";
            this.ControlBox.Size = new System.Drawing.Size(64, 22);
            this.ControlBox.TabIndex = 2;
            this.ControlBox.Text = "ambiance_ControlBox1";
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 565);
            this.Controls.Add(this.ambiance_ThemeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(261, 65);
            this.Name = "MainPage";
            this.Text = "Generic Learning Platform";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.ambiance_ThemeContainer1.ResumeLayout(false);
            this.classTabs.ResumeLayout(false);
            this.testTab.ResumeLayout(false);
            this.testTab.PerformLayout();
            this.ambiance_Panel1.ResumeLayout(false);
            this.ambiance_Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Ambiance.Ambiance_ThemeContainer ambiance_ThemeContainer1;
#pragma warning disable CS0108 // Member hides inherited member; missing new keyword
        private Ambiance.Ambiance_ControlBox ControlBox;
#pragma warning restore CS0108 // Member hides inherited member; missing new keyword
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public Ambiance.Ambiance_TabControl classTabs;
        private Ambiance.Ambiance_Button_1 addStudentButton;
        private Ambiance.Ambiance_Button_2 createClassButton;
        private System.Windows.Forms.TabPage testTab;
        private Ambiance.Ambiance_HeaderLabel ambiance_HeaderLabel1;
        private Ambiance.Ambiance_ComboBox ambiance_ComboBox1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private Ambiance.Ambiance_Label ambiance_Label3;
        private Ambiance.Ambiance_Label ambiance_Label1;
        private Ambiance.Ambiance_Label ambiance_Label2;
        private Ambiance.Ambiance_Button_2 ambiance_Button_21;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private Ambiance.Ambiance_Separator ambiance_Separator1;
        private Ambiance.Ambiance_TextBox ambiance_TextBox1;
        private Ambiance.Ambiance_Panel ambiance_Panel1;
        private Ambiance.Ambiance_Label ambiance_Label4;
        private Ambiance.Ambiance_Button_1 ambiance_Button_11;
        private Ambiance.Ambiance_Label ambiance_Label5;
        private Ambiance.Ambiance_Separator ambiance_Separator2;
        private Ambiance.Ambiance_TextBox ambiance_TextBox2;
    }
}
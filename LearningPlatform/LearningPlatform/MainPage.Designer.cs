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
            this.ambiance_ThemeContainer1 = new Ambiance.Ambiance_ThemeContainer();
            this.TESTERBUTTON = new Ambiance.Ambiance_Button_1();
            this.addStudentButton = new Ambiance.Ambiance_Button_1();
            this.createClassButton = new Ambiance.Ambiance_Button_2();
            this.classTabs = new Ambiance.Ambiance_TabControl();
            this.ControlBox = new Ambiance.Ambiance_ControlBox();
            this.testTab = new System.Windows.Forms.TabPage();
            this.ambiance_ComboBox1 = new Ambiance.Ambiance_ComboBox();
            this.ambiance_HeaderLabel1 = new Ambiance.Ambiance_HeaderLabel();
            this.ambiance_ThemeContainer1.SuspendLayout();
            this.classTabs.SuspendLayout();
            this.testTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // ambiance_ThemeContainer1
            // 
            this.ambiance_ThemeContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.ambiance_ThemeContainer1.Controls.Add(this.TESTERBUTTON);
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
            // TESTERBUTTON
            // 
            this.TESTERBUTTON.BackColor = System.Drawing.Color.Transparent;
            this.TESTERBUTTON.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TESTERBUTTON.Image = null;
            this.TESTERBUTTON.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TESTERBUTTON.Location = new System.Drawing.Point(787, 505);
            this.TESTERBUTTON.Name = "TESTERBUTTON";
            this.TESTERBUTTON.Size = new System.Drawing.Size(117, 30);
            this.TESTERBUTTON.TabIndex = 7;
            this.TESTERBUTTON.Text = "TESTER";
            this.TESTERBUTTON.TextAlignment = System.Drawing.StringAlignment.Center;
            this.TESTERBUTTON.Click += new System.EventHandler(this.TESTERBUTTON_Click);
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
            // testTab
            // 
            this.testTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.testTab.Controls.Add(this.ambiance_HeaderLabel1);
            this.testTab.Controls.Add(this.ambiance_ComboBox1);
            this.testTab.Location = new System.Drawing.Point(4, 28);
            this.testTab.Name = "testTab";
            this.testTab.Padding = new System.Windows.Forms.Padding(3);
            this.testTab.Size = new System.Drawing.Size(913, 395);
            this.testTab.TabIndex = 0;
            this.testTab.Text = "Test Tab";
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
            this.ResumeLayout(false);

        }

        #endregion

        private Ambiance.Ambiance_ThemeContainer ambiance_ThemeContainer1;
        private Ambiance.Ambiance_ControlBox ControlBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public Ambiance.Ambiance_TabControl classTabs;
        private Ambiance.Ambiance_Button_1 TESTERBUTTON;
        private Ambiance.Ambiance_Button_1 addStudentButton;
        private Ambiance.Ambiance_Button_2 createClassButton;
        private System.Windows.Forms.TabPage testTab;
        private Ambiance.Ambiance_HeaderLabel ambiance_HeaderLabel1;
        private Ambiance.Ambiance_ComboBox ambiance_ComboBox1;
    }
}
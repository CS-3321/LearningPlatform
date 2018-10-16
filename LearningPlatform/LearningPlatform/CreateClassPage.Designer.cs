namespace LearningPlatform
{
    partial class CreateClassPage
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
            this.CreateClassForm = new Ambiance.Ambiance_ThemeContainer();
            this.cancelButton = new Ambiance.Ambiance_Button_1();
            this.CreateClassButton = new Ambiance.Ambiance_Button_2();
            this.CreateClassForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateClassForm
            // 
            this.CreateClassForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.CreateClassForm.Controls.Add(this.CreateClassButton);
            this.CreateClassForm.Controls.Add(this.cancelButton);
            this.CreateClassForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CreateClassForm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CreateClassForm.Location = new System.Drawing.Point(0, 0);
            this.CreateClassForm.Name = "CreateClassForm";
            this.CreateClassForm.Padding = new System.Windows.Forms.Padding(20, 56, 20, 16);
            this.CreateClassForm.RoundCorners = true;
            this.CreateClassForm.Sizable = true;
            this.CreateClassForm.Size = new System.Drawing.Size(327, 439);
            this.CreateClassForm.SmartBounds = true;
            this.CreateClassForm.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.CreateClassForm.TabIndex = 0;
            this.CreateClassForm.Text = "Create Class";
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Transparent;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cancelButton.Image = null;
            this.cancelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelButton.Location = new System.Drawing.Point(183, 362);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(117, 30);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // CreateClassButton
            // 
            this.CreateClassButton.BackColor = System.Drawing.Color.Transparent;
            this.CreateClassButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.CreateClassButton.Image = null;
            this.CreateClassButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CreateClassButton.Location = new System.Drawing.Point(32, 362);
            this.CreateClassButton.Name = "CreateClassButton";
            this.CreateClassButton.Size = new System.Drawing.Size(126, 30);
            this.CreateClassButton.TabIndex = 1;
            this.CreateClassButton.Text = "Create Class";
            this.CreateClassButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.CreateClassButton.Click += new System.EventHandler(this.CreateClassButton_Click);
            // 
            // CreateClassPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 439);
            this.Controls.Add(this.CreateClassForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(261, 65);
            this.Name = "CreateClassPage";
            this.Text = "Create Class";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.CreateClassForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Ambiance.Ambiance_ThemeContainer CreateClassForm;
        private Ambiance.Ambiance_Button_2 CreateClassButton;
        private Ambiance.Ambiance_Button_1 cancelButton;
    }
}
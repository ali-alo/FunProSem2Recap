﻿namespace WIUT
{
    partial class ParentForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coursesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allCoursesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newApplicantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allApplicantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.applicantsToolStripMenuItem,
            this.coursesToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // applicantsToolStripMenuItem
            // 
            this.applicantsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newApplicantToolStripMenuItem,
            this.allApplicantsToolStripMenuItem});
            this.applicantsToolStripMenuItem.Name = "applicantsToolStripMenuItem";
            this.applicantsToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.applicantsToolStripMenuItem.Text = "Applicants";
            // 
            // coursesToolStripMenuItem
            // 
            this.coursesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCourseToolStripMenuItem,
            this.allCoursesToolStripMenuItem});
            this.coursesToolStripMenuItem.Name = "coursesToolStripMenuItem";
            this.coursesToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.coursesToolStripMenuItem.Text = "Courses";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // newCourseToolStripMenuItem
            // 
            this.newCourseToolStripMenuItem.Name = "newCourseToolStripMenuItem";
            this.newCourseToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.newCourseToolStripMenuItem.Text = "New course";
            // 
            // allCoursesToolStripMenuItem
            // 
            this.allCoursesToolStripMenuItem.Name = "allCoursesToolStripMenuItem";
            this.allCoursesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.allCoursesToolStripMenuItem.Text = "All courses";
            // 
            // newApplicantToolStripMenuItem
            // 
            this.newApplicantToolStripMenuItem.Name = "newApplicantToolStripMenuItem";
            this.newApplicantToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.newApplicantToolStripMenuItem.Text = "New applicant";
            // 
            // allApplicantsToolStripMenuItem
            // 
            this.allApplicantsToolStripMenuItem.Name = "allApplicantsToolStripMenuItem";
            this.allApplicantsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.allApplicantsToolStripMenuItem.Text = "All applicants";
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ParentForm";
            this.Text = "WIUT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applicantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newApplicantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allApplicantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coursesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allCoursesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}
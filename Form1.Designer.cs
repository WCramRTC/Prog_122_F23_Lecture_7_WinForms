namespace Prog_122_F23_Lecture_7_WinForms
{
    partial class Form1
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
            this.btnDisplay = new System.Windows.Forms.Button();
            this.tbCourseName = new System.Windows.Forms.TextBox();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblCourseId = new System.Windows.Forms.Label();
            this.tbCourseId = new System.Windows.Forms.TextBox();
            this.tbCourseRoomNum = new System.Windows.Forms.TextBox();
            this.lblCourseRoomNum = new System.Windows.Forms.Label();
            this.tbCourseStudent = new System.Windows.Forms.TextBox();
            this.lblCourseStudent = new System.Windows.Forms.Label();
            this.tbCourseTeacher = new System.Windows.Forms.TextBox();
            this.lblCourseTeacher = new System.Windows.Forms.Label();
            this.rtbDisplay = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(12, 343);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(406, 44);
            this.btnDisplay.TabIndex = 0;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // tbCourseName
            // 
            this.tbCourseName.Location = new System.Drawing.Point(572, 23);
            this.tbCourseName.Name = "tbCourseName";
            this.tbCourseName.Size = new System.Drawing.Size(191, 26);
            this.tbCourseName.TabIndex = 1;
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Location = new System.Drawing.Point(449, 26);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(106, 20);
            this.lblCourseName.TabIndex = 2;
            this.lblCourseName.Text = "Course Name";
            // 
            // lblCourseId
            // 
            this.lblCourseId.AutoSize = true;
            this.lblCourseId.Location = new System.Drawing.Point(449, 75);
            this.lblCourseId.Name = "lblCourseId";
            this.lblCourseId.Size = new System.Drawing.Size(81, 20);
            this.lblCourseId.TabIndex = 4;
            this.lblCourseId.Text = "Course ID";
            // 
            // tbCourseId
            // 
            this.tbCourseId.Location = new System.Drawing.Point(572, 72);
            this.tbCourseId.Name = "tbCourseId";
            this.tbCourseId.Size = new System.Drawing.Size(191, 26);
            this.tbCourseId.TabIndex = 3;
            // 
            // tbCourseRoomNum
            // 
            this.tbCourseRoomNum.Location = new System.Drawing.Point(572, 127);
            this.tbCourseRoomNum.Name = "tbCourseRoomNum";
            this.tbCourseRoomNum.Size = new System.Drawing.Size(191, 26);
            this.tbCourseRoomNum.TabIndex = 5;
            // 
            // lblCourseRoomNum
            // 
            this.lblCourseRoomNum.AutoSize = true;
            this.lblCourseRoomNum.Location = new System.Drawing.Point(449, 130);
            this.lblCourseRoomNum.Name = "lblCourseRoomNum";
            this.lblCourseRoomNum.Size = new System.Drawing.Size(107, 20);
            this.lblCourseRoomNum.TabIndex = 6;
            this.lblCourseRoomNum.Text = "Course Room";
            // 
            // tbCourseStudent
            // 
            this.tbCourseStudent.Location = new System.Drawing.Point(572, 186);
            this.tbCourseStudent.Name = "tbCourseStudent";
            this.tbCourseStudent.Size = new System.Drawing.Size(191, 26);
            this.tbCourseStudent.TabIndex = 7;
            // 
            // lblCourseStudent
            // 
            this.lblCourseStudent.AutoSize = true;
            this.lblCourseStudent.Location = new System.Drawing.Point(449, 189);
            this.lblCourseStudent.Name = "lblCourseStudent";
            this.lblCourseStudent.Size = new System.Drawing.Size(121, 20);
            this.lblCourseStudent.TabIndex = 8;
            this.lblCourseStudent.Text = "Course Student";
            // 
            // tbCourseTeacher
            // 
            this.tbCourseTeacher.Location = new System.Drawing.Point(572, 245);
            this.tbCourseTeacher.Name = "tbCourseTeacher";
            this.tbCourseTeacher.Size = new System.Drawing.Size(191, 26);
            this.tbCourseTeacher.TabIndex = 9;
            // 
            // lblCourseTeacher
            // 
            this.lblCourseTeacher.AutoSize = true;
            this.lblCourseTeacher.Location = new System.Drawing.Point(449, 248);
            this.lblCourseTeacher.Name = "lblCourseTeacher";
            this.lblCourseTeacher.Size = new System.Drawing.Size(122, 20);
            this.lblCourseTeacher.TabIndex = 10;
            this.lblCourseTeacher.Text = "Course Teacher";
            // 
            // rtbDisplay
            // 
            this.rtbDisplay.Location = new System.Drawing.Point(12, 12);
            this.rtbDisplay.Name = "rtbDisplay";
            this.rtbDisplay.Size = new System.Drawing.Size(406, 279);
            this.rtbDisplay.TabIndex = 11;
            this.rtbDisplay.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 433);
            this.Controls.Add(this.rtbDisplay);
            this.Controls.Add(this.lblCourseTeacher);
            this.Controls.Add(this.tbCourseTeacher);
            this.Controls.Add(this.lblCourseStudent);
            this.Controls.Add(this.tbCourseStudent);
            this.Controls.Add(this.lblCourseRoomNum);
            this.Controls.Add(this.tbCourseRoomNum);
            this.Controls.Add(this.lblCourseId);
            this.Controls.Add(this.tbCourseId);
            this.Controls.Add(this.lblCourseName);
            this.Controls.Add(this.tbCourseName);
            this.Controls.Add(this.btnDisplay);
            this.Name = "Form1";
            this.Text = "Lecture 7 App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.TextBox tbCourseName;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblCourseId;
        private System.Windows.Forms.TextBox tbCourseId;
        private System.Windows.Forms.TextBox tbCourseRoomNum;
        private System.Windows.Forms.Label lblCourseRoomNum;
        private System.Windows.Forms.TextBox tbCourseStudent;
        private System.Windows.Forms.Label lblCourseStudent;
        private System.Windows.Forms.TextBox tbCourseTeacher;
        private System.Windows.Forms.Label lblCourseTeacher;
        private System.Windows.Forms.RichTextBox rtbDisplay;
    }
}


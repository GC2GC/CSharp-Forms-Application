
namespace WindowsFormsApp
{
    partial class frmSchedule
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
            this.next = new System.Windows.Forms.Button();
            this.previous = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtScheduleID = new System.Windows.Forms.TextBox();
            this.Stud_notes = new System.Windows.Forms.Label();
            this.txtCourseID = new System.Windows.Forms.TextBox();
            this.txtAssessorID = new System.Windows.Forms.TextBox();
            this.stud_Postcode = new System.Windows.Forms.Label();
            this.stud_address = new System.Windows.Forms.Label();
            this.txtCourseDate = new System.Windows.Forms.TextBox();
            this.txtCourseAchieved = new System.Windows.Forms.TextBox();
            this.txtStuID = new System.Windows.Forms.TextBox();
            this.txtVenueID = new System.Windows.Forms.TextBox();
            this.lblMobile = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblStudent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(413, 288);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(75, 23);
            this.next.TabIndex = 0;
            this.next.Text = "next";
            this.next.UseVisualStyleBackColor = true;
            // 
            // previous
            // 
            this.previous.Location = new System.Drawing.Point(256, 288);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(75, 23);
            this.previous.TabIndex = 1;
            this.previous.Text = "previous";
            this.previous.UseVisualStyleBackColor = true;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(548, 288);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 2;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(664, 50);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Menu";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtScheduleID
            // 
            this.txtScheduleID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScheduleID.Location = new System.Drawing.Point(465, 38);
            this.txtScheduleID.Name = "txtScheduleID";
            this.txtScheduleID.Size = new System.Drawing.Size(100, 20);
            this.txtScheduleID.TabIndex = 13;
            // 
            // Stud_notes
            // 
            this.Stud_notes.AutoSize = true;
            this.Stud_notes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stud_notes.Location = new System.Drawing.Point(229, 33);
            this.Stud_notes.Name = "Stud_notes";
            this.Stud_notes.Size = new System.Drawing.Size(218, 25);
            this.Stud_notes.TabIndex = 12;
            this.Stud_notes.Text = "Course schedule ID";
            // 
            // txtCourseID
            // 
            this.txtCourseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseID.Location = new System.Drawing.Point(417, 79);
            this.txtCourseID.Name = "txtCourseID";
            this.txtCourseID.Size = new System.Drawing.Size(100, 20);
            this.txtCourseID.TabIndex = 25;
            // 
            // txtAssessorID
            // 
            this.txtAssessorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssessorID.Location = new System.Drawing.Point(417, 115);
            this.txtAssessorID.Name = "txtAssessorID";
            this.txtAssessorID.Size = new System.Drawing.Size(100, 20);
            this.txtAssessorID.TabIndex = 24;
            // 
            // stud_Postcode
            // 
            this.stud_Postcode.AutoSize = true;
            this.stud_Postcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stud_Postcode.Location = new System.Drawing.Point(227, 73);
            this.stud_Postcode.Name = "stud_Postcode";
            this.stud_Postcode.Size = new System.Drawing.Size(116, 25);
            this.stud_Postcode.TabIndex = 23;
            this.stud_Postcode.Text = "Course ID";
            // 
            // stud_address
            // 
            this.stud_address.AutoSize = true;
            this.stud_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stud_address.Location = new System.Drawing.Point(227, 109);
            this.stud_address.Name = "stud_address";
            this.stud_address.Size = new System.Drawing.Size(150, 25);
            this.stud_address.TabIndex = 22;
            this.stud_address.Text = "Assesssor ID";
            // 
            // txtCourseDate
            // 
            this.txtCourseDate.Location = new System.Drawing.Point(400, 258);
            this.txtCourseDate.Name = "txtCourseDate";
            this.txtCourseDate.Size = new System.Drawing.Size(100, 20);
            this.txtCourseDate.TabIndex = 18;
            // 
            // txtCourseAchieved
            // 
            this.txtCourseAchieved.Location = new System.Drawing.Point(424, 223);
            this.txtCourseAchieved.Name = "txtCourseAchieved";
            this.txtCourseAchieved.Size = new System.Drawing.Size(100, 20);
            this.txtCourseAchieved.TabIndex = 19;
            // 
            // txtStuID
            // 
            this.txtStuID.Location = new System.Drawing.Point(400, 183);
            this.txtStuID.Name = "txtStuID";
            this.txtStuID.Size = new System.Drawing.Size(100, 20);
            this.txtStuID.TabIndex = 20;
            // 
            // txtVenueID
            // 
            this.txtVenueID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVenueID.Location = new System.Drawing.Point(400, 144);
            this.txtVenueID.Name = "txtVenueID";
            this.txtVenueID.Size = new System.Drawing.Size(100, 20);
            this.txtVenueID.TabIndex = 21;
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMobile.Location = new System.Drawing.Point(225, 258);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(143, 25);
            this.lblMobile.TabIndex = 14;
            this.lblMobile.Text = "Course Date";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(227, 217);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(191, 25);
            this.lblEmail.TabIndex = 15;
            this.lblEmail.Text = "Course Achieved";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(227, 178);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(122, 25);
            this.lblName.TabIndex = 16;
            this.lblName.Text = "Student ID";
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudent.Location = new System.Drawing.Point(227, 144);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(108, 25);
            this.lblStudent.TabIndex = 17;
            this.lblStudent.Text = "Venue ID";
            // 
            // frmSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCourseID);
            this.Controls.Add(this.txtAssessorID);
            this.Controls.Add(this.stud_Postcode);
            this.Controls.Add(this.stud_address);
            this.Controls.Add(this.txtCourseDate);
            this.Controls.Add(this.txtCourseAchieved);
            this.Controls.Add(this.txtStuID);
            this.Controls.Add(this.txtVenueID);
            this.Controls.Add(this.lblMobile);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.txtScheduleID);
            this.Controls.Add(this.Stud_notes);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.previous);
            this.Controls.Add(this.next);
            this.Name = "frmSchedule";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button previous;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtScheduleID;
        private System.Windows.Forms.Label Stud_notes;
        private System.Windows.Forms.TextBox txtCourseID;
        private System.Windows.Forms.TextBox txtAssessorID;
        private System.Windows.Forms.Label stud_Postcode;
        private System.Windows.Forms.Label stud_address;
        private System.Windows.Forms.TextBox txtCourseDate;
        private System.Windows.Forms.TextBox txtCourseAchieved;
        private System.Windows.Forms.TextBox txtStuID;
        private System.Windows.Forms.TextBox txtVenueID;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStudent;
    }
}
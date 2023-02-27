
namespace WindowsFormsApp
{
    partial class frmCourse
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
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.txtCourseCost = new System.Windows.Forms.TextBox();
            this.stud_Postcode = new System.Windows.Forms.Label();
            this.stud_address = new System.Windows.Forms.Label();
            this.txtCourseDuration = new System.Windows.Forms.TextBox();
            this.lblStudent = new System.Windows.Forms.Label();
            this.txtCourseID = new System.Windows.Forms.TextBox();
            this.Stud_notes = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.previous = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.txtRecordCount = new System.Windows.Forms.TextBox();
            this.Update = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.UpdateBox = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.DeleteText = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCourseName
            // 
            this.txtCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseName.Location = new System.Drawing.Point(203, 70);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(100, 20);
            this.txtCourseName.TabIndex = 43;
            // 
            // txtCourseCost
            // 
            this.txtCourseCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseCost.Location = new System.Drawing.Point(203, 96);
            this.txtCourseCost.Name = "txtCourseCost";
            this.txtCourseCost.Size = new System.Drawing.Size(100, 20);
            this.txtCourseCost.TabIndex = 42;
            // 
            // stud_Postcode
            // 
            this.stud_Postcode.AutoSize = true;
            this.stud_Postcode.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stud_Postcode.Location = new System.Drawing.Point(17, 64);
            this.stud_Postcode.Name = "stud_Postcode";
            this.stud_Postcode.Size = new System.Drawing.Size(145, 24);
            this.stud_Postcode.TabIndex = 41;
            this.stud_Postcode.Text = "Course name";
            // 
            // stud_address
            // 
            this.stud_address.AutoSize = true;
            this.stud_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stud_address.Location = new System.Drawing.Point(16, 88);
            this.stud_address.Name = "stud_address";
            this.stud_address.Size = new System.Drawing.Size(138, 25);
            this.stud_address.TabIndex = 40;
            this.stud_address.Text = "Course cost";
            this.stud_address.Click += new System.EventHandler(this.stud_address_Click);
            // 
            // txtCourseDuration
            // 
            this.txtCourseDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseDuration.Location = new System.Drawing.Point(203, 122);
            this.txtCourseDuration.Name = "txtCourseDuration";
            this.txtCourseDuration.Size = new System.Drawing.Size(100, 20);
            this.txtCourseDuration.TabIndex = 39;
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudent.Location = new System.Drawing.Point(16, 113);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(180, 25);
            this.lblStudent.TabIndex = 35;
            this.lblStudent.Text = "Course duration";
            // 
            // txtCourseID
            // 
            this.txtCourseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseID.Location = new System.Drawing.Point(203, 40);
            this.txtCourseID.Name = "txtCourseID";
            this.txtCourseID.Size = new System.Drawing.Size(100, 20);
            this.txtCourseID.TabIndex = 31;
            // 
            // Stud_notes
            // 
            this.Stud_notes.AutoSize = true;
            this.Stud_notes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stud_notes.Location = new System.Drawing.Point(17, 40);
            this.Stud_notes.Name = "Stud_notes";
            this.Stud_notes.Size = new System.Drawing.Size(112, 24);
            this.Stud_notes.TabIndex = 30;
            this.Stud_notes.Text = "Course ID";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(713, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 29;
            this.button4.Text = "Menu";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(299, 157);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 28;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // previous
            // 
            this.previous.Location = new System.Drawing.Point(31, 154);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(75, 23);
            this.previous.TabIndex = 27;
            this.previous.Text = "previous";
            this.previous.UseVisualStyleBackColor = true;
            this.previous.Click += new System.EventHandler(this.previous_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(218, 155);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(75, 23);
            this.next.TabIndex = 26;
            this.next.Text = "next";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // txtRecordCount
            // 
            this.txtRecordCount.Location = new System.Drawing.Point(112, 157);
            this.txtRecordCount.Name = "txtRecordCount";
            this.txtRecordCount.Size = new System.Drawing.Size(100, 20);
            this.txtRecordCount.TabIndex = 44;
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(480, 100);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 45;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(366, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 39);
            this.label2.TabIndex = 46;
            this.label2.Text = "To update a value, enter the name in the field \r\nbelow and fill in the remaining " +
    "\r\nvalues and press update";
            // 
            // UpdateBox
            // 
            this.UpdateBox.Location = new System.Drawing.Point(369, 103);
            this.UpdateBox.Name = "UpdateBox";
            this.UpdateBox.Size = new System.Drawing.Size(100, 20);
            this.UpdateBox.TabIndex = 47;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(437, 195);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 48;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // DeleteText
            // 
            this.DeleteText.Location = new System.Drawing.Point(331, 198);
            this.DeleteText.Name = "DeleteText";
            this.DeleteText.Size = new System.Drawing.Size(100, 20);
            this.DeleteText.TabIndex = 49;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(702, 224);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 50;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(331, 253);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(457, 185);
            this.dataGridView1.TabIndex = 51;
            // 
            // frmCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.DeleteText);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.UpdateBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.txtRecordCount);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.txtCourseCost);
            this.Controls.Add(this.stud_Postcode);
            this.Controls.Add(this.stud_address);
            this.Controls.Add(this.txtCourseDuration);
            this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.txtCourseID);
            this.Controls.Add(this.Stud_notes);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.previous);
            this.Controls.Add(this.next);
            this.Name = "frmCourse";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.frmCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.TextBox txtCourseCost;
        private System.Windows.Forms.Label stud_Postcode;
        private System.Windows.Forms.Label stud_address;
        private System.Windows.Forms.TextBox txtCourseDuration;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.TextBox txtCourseID;
        private System.Windows.Forms.Label Stud_notes;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button previous;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.TextBox txtRecordCount;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UpdateBox;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox DeleteText;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
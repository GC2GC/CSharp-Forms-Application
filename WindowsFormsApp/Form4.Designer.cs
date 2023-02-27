
namespace WindowsFormsApp
{
    partial class frmAssessor
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
            this.txtAssessName = new System.Windows.Forms.TextBox();
            this.txtAssessorAddress = new System.Windows.Forms.TextBox();
            this.stud_Postcode = new System.Windows.Forms.Label();
            this.stud_address = new System.Windows.Forms.Label();
            this.txtAssessorEmail = new System.Windows.Forms.TextBox();
            this.txtAssessorMob = new System.Windows.Forms.TextBox();
            this.txtAssessorPostcode = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblStudent = new System.Windows.Forms.Label();
            this.txtAssessID = new System.Windows.Forms.TextBox();
            this.Stud_notes = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.previous = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.txtRecordCount = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.deleteTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtAssessName
            // 
            this.txtAssessName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssessName.Location = new System.Drawing.Point(202, 76);
            this.txtAssessName.Name = "txtAssessName";
            this.txtAssessName.Size = new System.Drawing.Size(100, 20);
            this.txtAssessName.TabIndex = 43;
            // 
            // txtAssessorAddress
            // 
            this.txtAssessorAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssessorAddress.Location = new System.Drawing.Point(219, 112);
            this.txtAssessorAddress.Name = "txtAssessorAddress";
            this.txtAssessorAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAssessorAddress.TabIndex = 42;
            // 
            // stud_Postcode
            // 
            this.stud_Postcode.AutoSize = true;
            this.stud_Postcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stud_Postcode.Location = new System.Drawing.Point(12, 70);
            this.stud_Postcode.Name = "stud_Postcode";
            this.stud_Postcode.Size = new System.Drawing.Size(171, 25);
            this.stud_Postcode.TabIndex = 41;
            this.stud_Postcode.Text = "assessor name";
            // 
            // stud_address
            // 
            this.stud_address.AutoSize = true;
            this.stud_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stud_address.Location = new System.Drawing.Point(12, 106);
            this.stud_address.Name = "stud_address";
            this.stud_address.Size = new System.Drawing.Size(198, 25);
            this.stud_address.TabIndex = 40;
            this.stud_address.Text = "assessor address";
            // 
            // txtAssessorEmail
            // 
            this.txtAssessorEmail.Location = new System.Drawing.Point(185, 220);
            this.txtAssessorEmail.Name = "txtAssessorEmail";
            this.txtAssessorEmail.Size = new System.Drawing.Size(100, 20);
            this.txtAssessorEmail.TabIndex = 37;
            // 
            // txtAssessorMob
            // 
            this.txtAssessorMob.Location = new System.Drawing.Point(198, 181);
            this.txtAssessorMob.Name = "txtAssessorMob";
            this.txtAssessorMob.Size = new System.Drawing.Size(100, 20);
            this.txtAssessorMob.TabIndex = 38;
            this.txtAssessorMob.TextChanged += new System.EventHandler(this.txtStuName_TextChanged);
            // 
            // txtAssessorPostcode
            // 
            this.txtAssessorPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssessorPostcode.Location = new System.Drawing.Point(219, 141);
            this.txtAssessorPostcode.Name = "txtAssessorPostcode";
            this.txtAssessorPostcode.Size = new System.Drawing.Size(100, 20);
            this.txtAssessorPostcode.TabIndex = 39;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(12, 214);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(170, 25);
            this.lblEmail.TabIndex = 33;
            this.lblEmail.Text = "assessor email";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(12, 175);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(183, 25);
            this.lblName.TabIndex = 34;
            this.lblName.Text = "assessor mobile";
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudent.Location = new System.Drawing.Point(12, 141);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(210, 25);
            this.lblStudent.TabIndex = 35;
            this.lblStudent.Text = "assessor postcode";
            // 
            // txtAssessID
            // 
            this.txtAssessID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssessID.Location = new System.Drawing.Point(178, 35);
            this.txtAssessID.Name = "txtAssessID";
            this.txtAssessID.Size = new System.Drawing.Size(100, 20);
            this.txtAssessID.TabIndex = 31;
            // 
            // Stud_notes
            // 
            this.Stud_notes.AutoSize = true;
            this.Stud_notes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stud_notes.Location = new System.Drawing.Point(14, 30);
            this.Stud_notes.Name = "Stud_notes";
            this.Stud_notes.Size = new System.Drawing.Size(133, 25);
            this.Stud_notes.TabIndex = 30;
            this.Stud_notes.Text = "assessor id";
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
            this.Add.Location = new System.Drawing.Point(300, 260);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 28;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // previous
            // 
            this.previous.Location = new System.Drawing.Point(14, 263);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(75, 23);
            this.previous.TabIndex = 27;
            this.previous.Text = "previous";
            this.previous.UseVisualStyleBackColor = true;
            this.previous.Click += new System.EventHandler(this.previous_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(206, 261);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(75, 23);
            this.next.TabIndex = 26;
            this.next.Text = "next";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // txtRecordCount
            // 
            this.txtRecordCount.Location = new System.Drawing.Point(95, 263);
            this.txtRecordCount.Name = "txtRecordCount";
            this.txtRecordCount.Size = new System.Drawing.Size(100, 20);
            this.txtRecordCount.TabIndex = 44;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(357, 32);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 45;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(473, 138);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 46;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // deleteTxt
            // 
            this.deleteTxt.Location = new System.Drawing.Point(357, 140);
            this.deleteTxt.Name = "deleteTxt";
            this.deleteTxt.Size = new System.Drawing.Size(100, 20);
            this.deleteTxt.TabIndex = 47;
            // 
            // frmAssessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteTxt);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.txtRecordCount);
            this.Controls.Add(this.txtAssessName);
            this.Controls.Add(this.txtAssessorAddress);
            this.Controls.Add(this.stud_Postcode);
            this.Controls.Add(this.stud_address);
            this.Controls.Add(this.txtAssessorEmail);
            this.Controls.Add(this.txtAssessorMob);
            this.Controls.Add(this.txtAssessorPostcode);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.txtAssessID);
            this.Controls.Add(this.Stud_notes);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.previous);
            this.Controls.Add(this.next);
            this.Name = "frmAssessor";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.frmAssessor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAssessName;
        private System.Windows.Forms.TextBox txtAssessorAddress;
        private System.Windows.Forms.Label stud_Postcode;
        private System.Windows.Forms.Label stud_address;
        private System.Windows.Forms.TextBox txtAssessorEmail;
        private System.Windows.Forms.TextBox txtAssessorMob;
        private System.Windows.Forms.TextBox txtAssessorPostcode;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.TextBox txtAssessID;
        private System.Windows.Forms.Label Stud_notes;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button previous;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.TextBox txtRecordCount;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox deleteTxt;
    }
}
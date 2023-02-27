
namespace WindowsFormsApp
{
    partial class frmVenue
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
            this.txtVenueName = new System.Windows.Forms.TextBox();
            this.txtVenueAddress = new System.Windows.Forms.TextBox();
            this.stud_Postcode = new System.Windows.Forms.Label();
            this.stud_address = new System.Windows.Forms.Label();
            this.VenueEmail = new System.Windows.Forms.TextBox();
            this.txtManagerName = new System.Windows.Forms.TextBox();
            this.txtVenueMob = new System.Windows.Forms.TextBox();
            this.txtVenuePostcode = new System.Windows.Forms.TextBox();
            this.lblMobile = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblStudent = new System.Windows.Forms.Label();
            this.txtVenueID = new System.Windows.Forms.TextBox();
            this.Stud_notes = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.previous = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.VenueCost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GoogleMap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRecordCount = new System.Windows.Forms.TextBox();
            this.Update = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtDelete = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUpdate = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtVenueName
            // 
            this.txtVenueName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVenueName.Location = new System.Drawing.Point(200, 37);
            this.txtVenueName.Name = "txtVenueName";
            this.txtVenueName.Size = new System.Drawing.Size(100, 20);
            this.txtVenueName.TabIndex = 43;
            this.txtVenueName.TextChanged += new System.EventHandler(this.txtVenueName_TextChanged);
            // 
            // txtVenueAddress
            // 
            this.txtVenueAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVenueAddress.Location = new System.Drawing.Point(200, 63);
            this.txtVenueAddress.Name = "txtVenueAddress";
            this.txtVenueAddress.Size = new System.Drawing.Size(100, 20);
            this.txtVenueAddress.TabIndex = 42;
            // 
            // stud_Postcode
            // 
            this.stud_Postcode.AutoSize = true;
            this.stud_Postcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stud_Postcode.Location = new System.Drawing.Point(8, 29);
            this.stud_Postcode.Name = "stud_Postcode";
            this.stud_Postcode.Size = new System.Drawing.Size(143, 25);
            this.stud_Postcode.TabIndex = 41;
            this.stud_Postcode.Text = "Vanue name";
            // 
            // stud_address
            // 
            this.stud_address.AutoSize = true;
            this.stud_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stud_address.Location = new System.Drawing.Point(8, 54);
            this.stud_address.Name = "stud_address";
            this.stud_address.Size = new System.Drawing.Size(170, 25);
            this.stud_address.TabIndex = 40;
            this.stud_address.Text = "Venue address";
            // 
            // VenueEmail
            // 
            this.VenueEmail.Location = new System.Drawing.Point(200, 179);
            this.VenueEmail.Name = "VenueEmail";
            this.VenueEmail.Size = new System.Drawing.Size(100, 20);
            this.VenueEmail.TabIndex = 36;
            // 
            // txtManagerName
            // 
            this.txtManagerName.Location = new System.Drawing.Point(200, 153);
            this.txtManagerName.Name = "txtManagerName";
            this.txtManagerName.Size = new System.Drawing.Size(100, 20);
            this.txtManagerName.TabIndex = 37;
            // 
            // txtVenueMob
            // 
            this.txtVenueMob.Location = new System.Drawing.Point(200, 117);
            this.txtVenueMob.Name = "txtVenueMob";
            this.txtVenueMob.Size = new System.Drawing.Size(100, 20);
            this.txtVenueMob.TabIndex = 38;
            // 
            // txtVenuePostcode
            // 
            this.txtVenuePostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVenuePostcode.Location = new System.Drawing.Point(200, 89);
            this.txtVenuePostcode.Name = "txtVenuePostcode";
            this.txtVenuePostcode.Size = new System.Drawing.Size(100, 20);
            this.txtVenuePostcode.TabIndex = 39;
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMobile.Location = new System.Drawing.Point(8, 172);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(142, 25);
            this.lblMobile.TabIndex = 32;
            this.lblMobile.Text = "Venue email";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(8, 147);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(168, 25);
            this.lblEmail.TabIndex = 33;
            this.lblEmail.Text = "Manager name";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(8, 111);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(155, 25);
            this.lblName.TabIndex = 34;
            this.lblName.Text = "Venue mobile";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudent.Location = new System.Drawing.Point(8, 81);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(182, 25);
            this.lblStudent.TabIndex = 35;
            this.lblStudent.Text = "Venue postcode";
            // 
            // txtVenueID
            // 
            this.txtVenueID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVenueID.Location = new System.Drawing.Point(200, 11);
            this.txtVenueID.Name = "txtVenueID";
            this.txtVenueID.Size = new System.Drawing.Size(100, 20);
            this.txtVenueID.TabIndex = 31;
            // 
            // Stud_notes
            // 
            this.Stud_notes.AutoSize = true;
            this.Stud_notes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stud_notes.Location = new System.Drawing.Point(8, 4);
            this.Stud_notes.Name = "Stud_notes";
            this.Stud_notes.Size = new System.Drawing.Size(108, 25);
            this.Stud_notes.TabIndex = 30;
            this.Stud_notes.Text = "Venue ID";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(713, 10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 29;
            this.button4.Text = "Menu";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(309, 266);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 28;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // previous
            // 
            this.previous.Location = new System.Drawing.Point(22, 264);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(75, 23);
            this.previous.TabIndex = 27;
            this.previous.Text = "previous";
            this.previous.UseVisualStyleBackColor = true;
            this.previous.Click += new System.EventHandler(this.previous_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(209, 263);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(75, 23);
            this.next.TabIndex = 26;
            this.next.Text = "next";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // VenueCost
            // 
            this.VenueCost.Location = new System.Drawing.Point(200, 205);
            this.VenueCost.Name = "VenueCost";
            this.VenueCost.Size = new System.Drawing.Size(100, 20);
            this.VenueCost.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 44;
            this.label1.Text = "Venue Cost";
            // 
            // GoogleMap
            // 
            this.GoogleMap.Location = new System.Drawing.Point(200, 231);
            this.GoogleMap.Name = "GoogleMap";
            this.GoogleMap.Size = new System.Drawing.Size(100, 20);
            this.GoogleMap.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 46;
            this.label2.Text = "Google map";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtRecordCount
            // 
            this.txtRecordCount.Location = new System.Drawing.Point(103, 266);
            this.txtRecordCount.Name = "txtRecordCount";
            this.txtRecordCount.Size = new System.Drawing.Size(100, 20);
            this.txtRecordCount.TabIndex = 48;
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(481, 63);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 49;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(481, 216);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 50;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtDelete
            // 
            this.txtDelete.Location = new System.Drawing.Point(375, 216);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(100, 20);
            this.txtDelete.TabIndex = 51;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(406, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(382, 150);
            this.dataGridView1.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 39);
            this.label3.TabIndex = 53;
            this.label3.Text = "To update a value, enter the name in the field \r\nbelow and fill in the remaining " +
    "\r\nvalues and press update";
            // 
            // txtUpdate
            // 
            this.txtUpdate.Location = new System.Drawing.Point(375, 63);
            this.txtUpdate.Name = "txtUpdate";
            this.txtUpdate.Size = new System.Drawing.Size(100, 20);
            this.txtUpdate.TabIndex = 54;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(692, 259);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 55;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(586, 261);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 56;
            // 
            // frmVenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.txtUpdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtDelete);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.txtRecordCount);
            this.Controls.Add(this.GoogleMap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.VenueCost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVenueName);
            this.Controls.Add(this.txtVenueAddress);
            this.Controls.Add(this.stud_Postcode);
            this.Controls.Add(this.stud_address);
            this.Controls.Add(this.VenueEmail);
            this.Controls.Add(this.txtManagerName);
            this.Controls.Add(this.txtVenueMob);
            this.Controls.Add(this.txtVenuePostcode);
            this.Controls.Add(this.lblMobile);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.txtVenueID);
            this.Controls.Add(this.Stud_notes);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.previous);
            this.Controls.Add(this.next);
            this.Name = "frmVenue";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.frmVenue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVenueName;
        private System.Windows.Forms.TextBox txtVenueAddress;
        private System.Windows.Forms.Label stud_Postcode;
        private System.Windows.Forms.Label stud_address;
        private System.Windows.Forms.TextBox VenueEmail;
        private System.Windows.Forms.TextBox txtManagerName;
        private System.Windows.Forms.TextBox txtVenueMob;
        private System.Windows.Forms.TextBox txtVenuePostcode;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.TextBox txtVenueID;
        private System.Windows.Forms.Label Stud_notes;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button previous;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.TextBox VenueCost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox GoogleMap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRecordCount;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUpdate;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox txtSearch;
    }
}
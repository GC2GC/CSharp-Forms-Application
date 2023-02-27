using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class frmStudent : Form
    {
        public frmStudent()
        {
            InitializeComponent();
        }
        DataTable Table = new DataTable();
        SqlDataAdapter adapter;
        int pos = 0;
        SqlConnection cnn;
        string sql;
        SqlCommand command;

        private void frmStudent_Load(object sender, EventArgs e)
        {

            string connectionString = (@"Data Source = HH-W4-IT2-05E\SQLEXPRESS;Initial Catalog = Unit18GC;Integrated Security = True;");
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            MessageBox.Show("You have successfully connected");
            cnn.Close();
            adapter = new SqlDataAdapter("Select * from Student", cnn);
            adapter.Fill(Table);
            ShowData(pos);
            
            UpdateBox.Text = "Enter Name here";

        }
        public void ShowData(int index)
        {
            txtStudID.Text = Table.Rows[index][0].ToString();
            txtStuName.Text = Table.Rows[index][1].ToString();
            txtAddress.Text = Table.Rows[index][2].ToString();
            txtPostcode.Text = Table.Rows[index][3].ToString();
            txtStuEmail.Text = Table.Rows[index][4].ToString();
            txtStuMob.Text = Table.Rows[index][5].ToString();
            txtNotes.Text = Table.Rows[index][6].ToString();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            pos++;
            if (pos < Table.Rows.Count) //check for last record
            {
                ShowData(pos);//update all controls by calling ShowData method created earlier
                Record_Count();
            }
            else
            {
                MessageBox.Show("End of Records"); //display message informing user when records end
            }

        }
        private void Record_Count()
        {
            //display the current record number and total record count, changing according to how to user toggles the navigation buttons
            txtRecordCount.Text = "Record " + (pos + 1).ToString() + " of " + (Table.Rows.Count).ToString();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            pos--; //decrement record position by 1
            if (pos >= 0) //check for last record 
            {
                ShowData(pos); //update all controls by calling ShowData method
                Record_Count(); //call Record_Count method to update record number displayed
            }
            else
            {
                MessageBox.Show("End of Records"); //displays end of records message, if clicking the 'previous' button whilst on the first record.

            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            //cnn.Open();

            try
            {
                cnn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("insert into Student(Student_Name,Student_Address,Student_Postcode,Student_Email,Student_Mobile,Student_Notes)values('" + txtStuName.Text + "','" + txtAddress.Text + "','" + txtPostcode.Text + "','" + txtStuEmail.Text + "','" + txtStuMob.Text + "','" + txtNotes.Text + "')", cnn);

                sda.SelectCommand.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("Inserted");
            }
            catch (Exception)
            {

                MessageBox.Show("Error when inserting");
            }
            //sql = "insert into Student values(@Student_ID,@Student_Name,@Student_Address,@Student_Postcode,@Student_Email,@Student_Mobile,@Student_Notes)";


        }


        private void button1_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Hide();
        }

        

        private void search_Click(object sender, EventArgs e)
        {

            cnn.Open();
            // SqlCommand command = new SqlCommand("select Student_Name, Student_Address, Student_Postcode, Student_Email, Student_Mobile, Student_Notes from Student where Student_ID = '"+ int.Parse(search.Text) +"'", cnn);
            SqlCommand command = new SqlCommand("select * from Student where Student_ID = '" + search.Text + "'", cnn);

            dataGridView1.DataSource = Table;
            cnn.Close();
        }

        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            cnn.Open();
            sql = "Delete Student where Student_Name = ('" + txtStuName.Text + "');";
            command = new SqlCommand(sql, cnn);
            DialogResult ConfirmDelete = MessageBox.Show("Are you sure you wish to delete the Record ? ", "Delete", MessageBoxButtons.YesNo,
           MessageBoxIcon.Warning);
            if (ConfirmDelete == DialogResult.Yes)
            {
                adapter.DeleteCommand = new SqlCommand(sql, cnn);
                adapter.DeleteCommand.ExecuteNonQuery();
                MessageBox.Show("Record Successfully Deleted");
            }
            command.Dispose();
            cnn.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            
               
            try
            {
                cnn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Update Student set Student_Name = '" + txtStuName.Text + "', Student_Address = '" + txtAddress.Text + "', Student_Postcode = '" + txtPostcode.Text + "', Student_Email = '" + txtStuEmail.Text + "' where Student_ID = '" + int.Parse(UpdateBox.Text) + "'", cnn);

                sda.SelectCommand.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("Successfully updated");
            }
            catch (Exception)
            {

                MessageBox.Show("Error when inserting");
            }

        }

        
    }
    }


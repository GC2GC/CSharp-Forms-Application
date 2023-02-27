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
    public partial class frmAssessor : Form
    {
        public frmAssessor()
        {
            InitializeComponent();
        }
        DataTable Table = new DataTable();
        SqlDataAdapter adapter;
        int pos = 0;
        SqlConnection cnn;
        string sql;
        SqlCommand command;

        private void frmAssessor_Load(object sender, EventArgs e)
        {

            string connectionString = (@"Data Source = HH-W4-IT2-05E\SQLEXPRESS;Initial Catalog = Unit18GC;Integrated Security = True;");
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            MessageBox.Show("You have successfully connected");
            cnn.Close();
            adapter = new SqlDataAdapter("Select * from Assessor", cnn);
            adapter.Fill(Table);
            ShowData(pos);
            //
        }
        public void ShowData(int index)
        {
            txtAssessID.Text = Table.Rows[index][0].ToString();
            txtAssessName.Text = Table.Rows[index][1].ToString();
            txtAssessorAddress.Text = Table.Rows[index][2].ToString();
            txtAssessorPostcode.Text = Table.Rows[index][3].ToString();
            txtAssessorMob.Text = Table.Rows[index][4].ToString();
            txtAssessorEmail.Text = Table.Rows[index][5].ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Hide();
        }

        

        private void txtStuName_TextChanged(object sender, EventArgs e)
        {

        }

        private void next_Click(object sender, EventArgs e)
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

        private void previous_Click(object sender, EventArgs e)
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

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("insert into Assessor(Assessor_ID,Assessor_Name,Assessor_Address,Assessor_Postcode,Assessor_Mobile,Assessor_Email)values('" + txtAssessID.Text + "','" + txtAssessName.Text + "','" + txtAssessorAddress.Text + "','" + txtAssessorPostcode.Text + "','" + txtAssessorMob.Text + "','" + txtAssessorEmail.Text + "')", cnn);

                sda.SelectCommand.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("Inserted");
            }
            catch (Exception)
            {

                MessageBox.Show("Error when inserting");
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Update Assessor set Assessor_Name = '" + txtAssessName.Text + "', Assessor_Address = '" + txtAssessorAddress.Text + "', Assessor_Postcode = '" + txtAssessorPostcode.Text + "', Assessor_Email = '" + txtAssessorEmail.Text + "' where Assessor_ID = '" + txtAssessID.Text + "'", cnn);

                sda.SelectCommand.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("Successfully updated");
            }
            catch (Exception)
            {

                MessageBox.Show("Error when inserting");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            cnn.Open();
            sql = "Delete Assessor where Assessor_ID = ('" + deleteTxt.Text + "');";
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
    }
}

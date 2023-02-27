using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp
{
    public partial class frmVenue : Form
    {
        

        private void button4_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Hide();
        }

        public frmVenue()
        {
            InitializeComponent();
        }
        DataTable Table = new DataTable();
        SqlDataAdapter adapter;
        int pos = 0;
        SqlConnection cnn;
        string sql;
        SqlCommand command;

        private void frmVenue_Load(object sender, EventArgs e)
        {

            string connectionString = (@"Data Source = HH-W4-IT2-05E\SQLEXPRESS;Initial Catalog = Unit18GC;Integrated Security = True;");
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            MessageBox.Show("You have successfully connected");
            cnn.Close();
            adapter = new SqlDataAdapter("Select * from Venue", cnn);
            adapter.Fill(Table);
            ShowData(pos);
            

        }
        public void ShowData(int index)
        {
            txtVenueID.Text = Table.Rows[index][0].ToString();
            txtVenueName.Text = Table.Rows[index][1].ToString();
            txtVenueAddress.Text = Table.Rows[index][2].ToString();
            txtVenuePostcode.Text = Table.Rows[index][3].ToString();
            txtVenueMob.Text = Table.Rows[index][4].ToString();
            txtManagerName.Text = Table.Rows[index][5].ToString();
            VenueEmail.Text = Table.Rows[index][6].ToString();
            VenueCost.Text = Table.Rows[index][7].ToString();
            GoogleMap.Text = Table.Rows[index][8].ToString();





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
                SqlDataAdapter sda = new SqlDataAdapter("insert into Venue(Venue_ID,Venue_Name,Venue_Address,Venue_Postcode,Venue_Mobile,Manager_Name,Venue_Email,Venue_Cost,Google_Map)values('" + txtVenueID.Text + "','" + txtVenueName.Text + "','" + txtVenueAddress.Text + "','" + txtVenuePostcode.Text + "','" + txtVenueMob.Text + "','" + txtManagerName.Text + "','" + VenueEmail.Text + "', '" + int.Parse(VenueCost.Text) + "', '" + GoogleMap.Text + "')", cnn);

                sda.SelectCommand.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("Inserted");
            }
            catch (Exception)
            {

                MessageBox.Show("Error when inserting");
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Update Venue set Venue_Name = '" + txtVenueName.Text + "', Venue_Address = '" + txtVenueAddress.Text + "', Venue_Postcode = '" + txtVenuePostcode.Text + "', Venue_Email = '" + VenueEmail.Text + "', Venue_Cost = '" + int.Parse(VenueCost.Text) + "', Google_Map = '" + VenueCost.Text + "' where Venue_ID = '" + txtUpdate.Text + "'", cnn);

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
            sql = "Delete Venue where Venue_ID = ('" + txtDelete.Text + "');";
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

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtVenueName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            cnn.Open();
            // SqlCommand command = new SqlCommand("select Student_Name, Student_Address, Student_Postcode, Student_Email, Student_Mobile, Student_Notes from Student where Student_ID = '"+ int.Parse(search.Text) +"'", cnn);
            SqlCommand command = new SqlCommand("select * from Venue where Venue_ID = '" + txtSearch.Text + "'", cnn);

            dataGridView1.DataSource = Table;
            cnn.Close();
        }
    }
}

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
    public partial class StudentMenu : Form
    {
        public StudentMenu()
        {
            InitializeComponent();
        }
        DataTable Table = new DataTable();
        SqlDataAdapter adapter;
        int pos = 0;
        SqlConnection cnn;
        string sql;
        SqlCommand command;

        private void StudentMenu_Load(object sender, EventArgs e)
        {

            string connectionString = (@"Data Source = HH-W4-IT2-05E\SQLEXPRESS;Initial Catalog = Unit18GC;Integrated Security = True;");
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            MessageBox.Show("You have successfully connected");
            cnn.Close();
            adapter = new SqlDataAdapter("Select * from Student", cnn);
            adapter.Fill(Table);
            ShowData(pos);
           

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            new StudentUpdate().Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            new StudentDelete().Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new StudentAdd().Show();
            this.Hide();
            cnn.Close();
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
    }
}

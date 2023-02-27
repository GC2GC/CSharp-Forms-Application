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
    public partial class StudentAdd : Form
    {
        public StudentAdd()
        {
            InitializeComponent();
        }
        DataTable Table = new DataTable();
        SqlDataAdapter adapter;
        int pos = 0;
        SqlConnection cnn;
        string sql;
        SqlCommand command;

        private void StudentAdd_Load(object sender, EventArgs e)
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


        public void btnAdd_Click(object sender, EventArgs e)
        {
           // try
          //  {
                cnn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("insert into Student(Student_Name,Student_Address,Student_Postcode,Student_Email,Student_Mobile,Student_Notes)values('" + txtStuName.Text + "','" + txtAddress.Text + "','" + txtPostcode.Text + "','" + txtStuEmail.Text + "','" + txtStuMob.Text + "','" + txtNotes.Text + "')", cnn);

                sda.SelectCommand.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("Inserted");
           // }
           // catch (Exception)
           // {

              //  MessageBox.Show("Error when inserting");
           // }
        }
    }
}

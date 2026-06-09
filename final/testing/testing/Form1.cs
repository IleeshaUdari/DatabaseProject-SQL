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

namespace testing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string ID = txtID.Text;
            string Name = txtName.Text;
            string Contact = txtContact.Text;
            string Email = txtEmail.Text;
            string Address = txtAddress.Text;

            if (ID == "" || Name == "" || Contact == "" || Email == "" || Address == "")
            {
                MessageBox.Show("Error : Fill all feilds first");
            }
            else
            {

                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into CLIENT (ID, Name, Contact, Email, Address) values('" + ID + "','" + Name + "','" + Contact + "','" + Email + "','" + Address + "') ", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Added Successfully");
                    con.Close();
                }

                catch (Exception ee)
                {
                    MessageBox.Show("Error: " + ee.ToString());
                    con.Close();
                }
                finally
                { con.Close(); }

                //Refresh the Dashboard

                Form1 dash = new Form1();
                this.Close();
                dash.Show();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string ID = txtID.Text;
            if (ID != "")
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from CLIENT where ID='" + ID + "'", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Deleted Successfully");
                    con.Close();
                }
                catch (Exception ee)
                {
                    MessageBox.Show("Error: " + ee.ToString());
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Error:Please fill ID first");
            }

            con.Close();

            //Refresh the Dashboard

            Form1 dash = new Form1();
            this.Close();
            dash.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string ID = txtID.Text;
            string Name = txtName.Text;
            string Contact = txtContact.Text;
            string Email = txtEmail.Text;
            string Address = txtAddress.Text;

            if (ID == "" || Name == "" || Contact == "" || Email == "" || Address == "")
            {
                MessageBox.Show("Error : Fill all feilds first");
            }
            else
            {

                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Update CLIENT SET ID = '" + ID + "','" + Name + "','" + Contact + "','" + Email + "','" + Address + "') ", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Updated Successfully");
                    con.Close();
                }

                catch (Exception ee)
                {
                    MessageBox.Show("Error: " + ee.ToString());
                    con.Close();
                }
                finally
                { con.Close(); }

                //Refresh the Dashboard

                Form1 dash = new Form1();
                this.Close();
                dash.Show();
            }
        }
    }
}

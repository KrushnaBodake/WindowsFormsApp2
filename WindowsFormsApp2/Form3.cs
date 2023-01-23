using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    
    public partial class Form3 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public Form3()
        {
            InitializeComponent();
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString);

        }       

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string qry="insert into Student Values(@name,@stream,@percentage,@age,@gender)";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@stream", txtStream.SelectedItem);
                cmd.Parameters.AddWithValue("@percentage", Convert.ToDouble(txtPercentage.Text));
                cmd.Parameters.AddWithValue("@age", Convert.ToInt32(txtAge.Text));
                cmd.Parameters.AddWithValue("@gender", txtGender.Text);
                con.Open();
                int result=cmd.ExecuteNonQuery();
                if(result==1)
                {
                    MessageBox.Show("Record inserted");
                }
            } 
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtAge.Clear();
            txtName.Clear();
            txtStream.ResetText();
            txtPercentage.Clear();
            txtGender.Clear();           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "Select*from Student Where rollno=@rollno";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@rollno", txtId.Text);
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        txtName.Text = dr["name"].ToString();
                       // string selectedItem = txtStream.Items[txtStream.SelectedIndex].ToString();
                        txtStream.Text = dr["stream"].ToString();
                        txtPercentage.Text = dr["percentage"].ToString();
                        txtAge.Text = dr["age"].ToString();
                        txtGender.Text = dr["gender"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Record Not Found");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "Update Student set name=@name,stream=@stream,percentage=@percentage,age=@age,gender=@gender where rollno=@rollno";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@stream", txtStream.SelectedItem);
                cmd.Parameters.AddWithValue("@percentage", Convert.ToDouble(txtPercentage.Text));
                cmd.Parameters.AddWithValue("@age", Convert.ToInt32(txtAge.Text));
                cmd.Parameters.AddWithValue("@gender", txtGender.Text);
                cmd.Parameters.AddWithValue("@rollno", Convert.ToInt32(txtId.Text));
                con.Open();
                int result =cmd.ExecuteNonQuery();
                if(result==1)
                {
                    MessageBox.Show("Record Updated");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "delete from Student where rollno=@rollno";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@rollno", Convert.ToInt32(txtId.Text));
                con.Open();
                int result=cmd.ExecuteNonQuery();
                if(result==1)
                {
                    MessageBox.Show("Record Deleted");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select *from Student";
                cmd = new SqlCommand(qry, con);
                con.Open();
                dr=cmd.ExecuteReader();
                if(dr.HasRows)
                {
                    DataTable table = new DataTable();
                    table.Load(dr);
                    GridView1.DataSource = table;
                }
                else
                {
                    MessageBox.Show("Record Not Found");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}

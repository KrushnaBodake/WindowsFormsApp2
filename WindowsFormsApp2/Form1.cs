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
using System.Configuration;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
            // step 1
            con= new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString);
        }
        private void ClearForm()
        {
            txtProdId.Clear();
            txtProdName.Clear();
            txtProdPrice.Clear();
            txtCompany.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // step 2 -  > write the sql query
                string qry = "insert into Product values(@name,@price,@comp)";
                //step 3 - assign the query to command class
                cmd = new SqlCommand(qry, con);
                // ste-4  assign values to the parameter
                cmd.Parameters.AddWithValue("@name", txtProdName. Text);
                cmd.Parameters.AddWithValue("@price", Convert.ToDouble(txtProdPrice .Text));
                cmd.Parameters.AddWithValue("@comp", txtCompany.Text);
                // step 5 - open conn
                con.Open();
                // step 6 - fire the query
                int result = cmd.ExecuteNonQuery(); // fire the insert /update / delete
                if (result == 1)
                {
                    MessageBox.Show("Record inserted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // step 7
                con.Close();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblProdName_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // step 2 -  > write the sql query
                string qry = "update Product set ProdName=@name,ProdPrice=@price, ProdCompanyName=@comp where  ProdId=@id";
                //step 3 - assign the query to command class
                cmd = new SqlCommand(qry, con);
                // step-4  assign values to the parameter
                cmd.Parameters.AddWithValue("@name", txtProdName.Text);
                cmd.Parameters.AddWithValue("@price", Convert.ToDouble(txtProdPrice.Text));
                cmd.Parameters.AddWithValue("@comp", txtCompany.Text);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtProdId.Text));
                // step 5 - open conn
                con.Open();
                // step 6 - fire the query
                int result = cmd.ExecuteNonQuery(); // fire the insert /update / delete
                if (result == 1)
                {
                    MessageBox.Show("Record updated");
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // step 7
                con.Close();
            }


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select * from Product where ProdId =@id";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtProdId.Text));
                con.Open();
                dr = cmd.ExecuteReader(); // fire the select query
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        txtProdName.Text = dr["ProdName"].ToString();
                        txtProdPrice.Text = dr["ProdPrice"].ToString();
                        txtCompany.Text = dr["ProdCompanyName"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Record not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // step 7
                con.Close();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // step 2 -  > write the sql query
                string qry = "delete from Product where ProdId=@id";
                //step 3 - assign the query to command class
                cmd = new SqlCommand(qry, con);
                // step-4  assing values to the parameter
                //cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtProdId.Text));
                // step 5 - open conn
                con.Open();
                // step 6 - fire the query
                int result = cmd.ExecuteNonQuery(); // fire the insert /update / delete
                if (result == 1)
                {
                    MessageBox.Show("Record deleted");
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // step 7
                con.Close();
            }

        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select * from Product";
                cmd = new SqlCommand(qry, con);
                con.Open();
                dr = cmd.ExecuteReader(); // fire the select query
                if (dr.HasRows)
                {
                    DataTable table = new DataTable();
                    table.Load(dr);
                    dataGridView1.DataSource = table;
                }
                else
                {
                    MessageBox.Show("Record not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // step 7
                con.Close();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}


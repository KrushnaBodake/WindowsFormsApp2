using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;      // configure DB with App
using System.Data.SqlClient;   

namespace WindowsFormsApp2
{
    public partial class Form4 : Form
    {
        SqlConnection con;     //Use To Connet app with db
        SqlCommand cmd;
        SqlDataReader dr;
        public Form4()
        {
            InitializeComponent();
            
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "insert into Book Values(@name,@price,@authorname,@edition,@publication)";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@name", txtBookName.Text);
                cmd.Parameters.AddWithValue("@price", Convert.ToDouble(txtPrice.Text));
                cmd.Parameters.AddWithValue("@authorname", txtName.Text);
                cmd.Parameters.AddWithValue("@edition", Convert.ToInt32(txtEdition.Text));
                cmd.Parameters.AddWithValue("publication", txtPublication.Text);
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Book Recored added Succesfully");
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select *from Book Where id=@id";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@id", txtBookId.Text);
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    if (dr.Read())
                    {
                        txtBookName.Text = dr["name"].ToString();
                        txtPrice.Text = dr["price"].ToString();
                        txtName.Text = dr["authorname"].ToString();
                        txtEdition.Text = dr["edition"].ToString();
                        txtPublication.Text = dr["publication"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Record Not Found");
                }
            }
            catch (Exception ex)
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
                string qry = "update Book set name=@name, price=@price,authorname=@authorname,edition=@edition,publication=@publication where id=@id";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@name", txtBookName.Text);
                cmd.Parameters.AddWithValue("@price", Convert.ToDouble(txtPrice.Text));
                cmd.Parameters.AddWithValue("@authorname", txtName.Text);
                cmd.Parameters.AddWithValue("@edition", Convert.ToInt32(txtEdition.Text));
                cmd.Parameters.AddWithValue("@publication",  txtPublication.Text);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtBookId.Text));

                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBookId.Clear();
            txtBookName.Clear();
            txtEdition.Clear();
            txtName.Clear();
            txtPrice.Clear();
            txtPublication.Clear();
            MessageBox.Show("Record Clear");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                String qry = "Delete from  Book where id=@id";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtBookId.Text));
                con.Open();
                int result = cmd.ExecuteNonQuery();
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

        private void btnShowall_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select * from Book";
                cmd = new SqlCommand(qry, con);
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable table = new DataTable();
                    table.Load(dr);
                    GridViewBook.DataSource = table;

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
                con.Close();
            }
        }
    }
}

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
    public partial class Form2 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public Form2()
        {
            InitializeComponent();
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString);

        }
        public void Clear()
        {
            txtEmpId.Clear();
            txtEMPName.Clear();
            txtDeptName.Clear();
            txtSalary.Clear();
            txtAge.Clear();
        }

        private void lblsalary_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string qry= "insert into Employee Values(@name,@deptname,@salary,@age)";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@name", txtEMPName.Text);
                cmd.Parameters.AddWithValue("@deptname", txtDeptName.Text);
                cmd.Parameters.AddWithValue("@salary", Convert.ToDouble(txtSalary.Text));
                cmd.Parameters.AddWithValue("@age", Convert.ToInt32(txtAge.Text));
                con.Open();
                int result=cmd.ExecuteNonQuery();
                if(result==1)
                {
                    MessageBox.Show("Record Inserted");
                    Clear();
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
                string qry = "select*from Employee where empid=@id";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@id", txtEmpId.Text);
                con.Open();
                dr=cmd.ExecuteReader();
                if(dr.HasRows)
                {
                    while(dr.Read())
                    {
                        txtEMPName.Text = dr["empname"].ToString();
                        txtDeptName.Text = dr["deptname"].ToString();
                        txtSalary.Text = dr["salary"].ToString();
                        txtAge.Text = dr["age"].ToString();
                        
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
                string qry = "update Employee set empname=@empname,deptname=@deptname,salary=@salary,age=@age where empid=@id";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@empname", txtEMPName.Text);
                cmd.Parameters.AddWithValue("@deptname", txtDeptName.Text);
                cmd.Parameters.AddWithValue("@salary", Convert.ToDouble(txtSalary.Text));
                cmd.Parameters.AddWithValue("@age", Convert.ToInt32(txtAge.Text));
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtEmpId.Text));
                con.Open();
                int result=cmd.ExecuteNonQuery();
                if(result==1)
                {
                    MessageBox.Show("Record Update ");
                    Clear();
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
                string qry = "delete from Employee where empid=@id";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@id",Convert.ToInt32( txtEmpId.Text));
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
                string qry = "Select*from Employee";
                cmd = new SqlCommand(qry,con);
                con.Open();
                dr=cmd.ExecuteReader();
                if(dr.HasRows)
                {
                    DataTable table = new DataTable();
                    table.Load(dr);
                    GridView.DataSource = table;
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

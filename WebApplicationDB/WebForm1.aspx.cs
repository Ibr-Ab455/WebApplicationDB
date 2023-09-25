using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationDB
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public object TextBoxFirstName { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {

           DataTable dt =new DataTable();
            var connectionString = ConfigurationManager.ConnectionStrings["ConnCms"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT * from person", conn);
                cmd.CommandType = CommandType.Text;

                SqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
                GridView1.DataSource = dt;
                GridView1.DataBind();

                reader.Close();
                conn.Close();
            }
        }

        protected void ButtonSearchLastName_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlParameter param;
            var connectionString = ConfigurationManager.ConnectionStrings["ConnCms"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT * from person where etternavn=@lastName", conn);
                cmd.CommandType = CommandType.Text;

                param=new SqlParameter("@lastName",SqlDbType.NChar);
                param.Value = TextBoxSearch.Text;
                cmd.Parameters.Add(param);


                SqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
                GridView1.DataSource = dt;
                GridView1.DataBind();

                reader.Close();
                conn.Close();
            }

        }

        protected void ButtonSearchFirstName_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlParameter param;
            var connectionString = ConfigurationManager.ConnectionStrings["ConnCms"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT * from person where Fornavn=@FirstName", conn);
                cmd.CommandType = CommandType.Text;

                param = new SqlParameter("@FirstName", SqlDbType.NChar);
                param.Value = TextBoxSearch.Text;
                cmd.Parameters.Add(param);


                SqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
                GridView1.DataSource = dt;
                GridView1.DataBind();

                reader.Close();
                conn.Close();
            }

        }

    }


}
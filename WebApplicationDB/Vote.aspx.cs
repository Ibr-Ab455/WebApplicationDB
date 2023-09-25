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
    public partial class Vote : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonVote_Click(object sender, EventArgs e)
        {
            //insert stemme til db
            DataTable dt = new DataTable();
            SqlParameter param;
            var connectionString = ConfigurationManager.ConnectionStrings["Valg"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO Stemme (Pid, Kid) VALUES (@partiId, 1)", conn);
                cmd.CommandType = CommandType.Text;

                param = new SqlParameter("@partiId", SqlDbType.Int);
                param.Value = DropDownListParti.SelectedItem.Value;
                cmd.Parameters.Add(param);


                cmd.ExecuteNonQuery();
               
                conn.Close();
            }
        }
    }
}
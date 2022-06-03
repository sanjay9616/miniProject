using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


namespace miniProject
{
    public partial class admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-4J6BVM3;Initial Catalog=miniProject;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("InsertInto", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", name.Text);
                cmd.Parameters.AddWithValue("@DOB", dob.Text);
                cmd.Parameters.AddWithValue("@UserName", txtUser.Text);
                cmd.Parameters.AddWithValue("@Password", txtPass.Text);
                cmd.Parameters.AddWithValue("@UserType", DropDownList1.SelectedValue);
                con.Open();
                cmd.ExecuteNonQuery();
                Server.Transfer("insert.aspx");
            }
        }
    }
}
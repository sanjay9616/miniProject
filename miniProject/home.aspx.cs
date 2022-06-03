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
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
         protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-4J6BVM3;Initial Catalog=miniProject;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("select * from miniProject where UserName='" + txtUser.Text + "' and Password='" + txtPass.Text + "' and UserType='" + DropDownList1.SelectedItem.ToString() + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Response.Write("<script>alert('You are logined as " + dt.Rows[0][2] + "')</script>");
                if (DropDownList1.SelectedIndex == 0)
                {
                    Server.Transfer("loginadmin.aspx");
                }
                else if (DropDownList1.SelectedIndex == 1)
                {
                    Server.Transfer("user.aspx");

                }

            }
            else
            {
                Response.Write("Error in you input");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Server.Transfer("admin.aspx");
        }
    }
}
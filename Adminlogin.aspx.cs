using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Apartment_Manager
{
    public partial class Adminlogin : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnAdminlogin_Click(object sender, EventArgs e)
        {
          

                try
                {
                    AppartmentTableAdapters.adminTableAdapter lg = new AppartmentTableAdapters.adminTableAdapter();
                    DataTable dt = new DataTable();
                    dt = lg.GetData(txtUsername.Text, txtPassword.Text);
                    /*
                    if(dt.Rows[0]["Id"].ToString() == "3")
                    {
                        Response.Redirect("Adminlogin.aspx");
                    }*/
                    if (dt.Rows.Count >= 1)
                    {
                        Session["userName"] = dt.Rows[0]["admin_name"].ToString();
                        lblConfirmLogin.Text = "Login Successful";
                        lblConfirmLogin.ForeColor = System.Drawing.Color.Green;
                        Response.Redirect("~/AdminDash.aspx");

                    }

                    else
                    {
                    Response.Redirect("~/Login.aspx");
                    }
                }
                catch (Exception ex)
                {
                    Response.Write(ex);
                }
            }
    }
}
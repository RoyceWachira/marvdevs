using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Apartment_Manager
{
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
           
            try
            {
                AppartmentTableAdapters.Login lg = new AppartmentTableAdapters.Login();
                DataTable dt = new DataTable();
                dt = lg.GetData(txtPassword.Text,txtUsername.Text);
                /*
                if(dt.Rows[0]["Id"].ToString() == "3")
                {
                    Response.Redirect("Adminlogin.aspx");
                }*/
                if (dt.Rows.Count >= 1)
                {
                    Session["userName"] = dt.Rows[0]["Name"].ToString();
                    lblConfirmLogin.Text = "Login Successful";
                    lblConfirmLogin.ForeColor = System.Drawing.Color.Green;
                    Response.Redirect("~/Dash.aspx");

                }
                
                else
                {
                    lblConfirmLogin.Text = "Incorrect Email or Password";
                    lblConfirmLogin.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch(Exception ex)
            {
                Response.Write(ex);
            }
            /*
            string check = "select count (*) from [Table] where Name='" + txtUsername.Text + " ' ";
            SqlCommand comm =new SqlCommand(check, con);
            int tom= Convert.ToInt32(comm.ExecuteReader().ToString());
            SqlDataReader dr = comm.ExecuteReader();
            
            if(dr.HasRows)
            {
                while (dr.Read())
                    Session["Name"] = txtUsername.Text;
            }
            dr.Close();
            con.Close();
            if(tom==1)
                con.Open();

            {
                string checkPassword = "select password from [Table] where Password= '" + txtPassword.Text + "'";
                SqlCommand pass = new SqlCommand(checkPassword, con);
                string passwordquery = pass.ExecuteScalar().ToString().Replace(" ", "");
                
                
                if(passwordquery==txtPassword.Text)
                {
                    Response.Write("Password is Correct");
                    Response.Redirect("Home.aspx");

                }
                else
                {
                    Response.Write("The password You've entered is incorrect.Please try again");

                }
               
            }

            con.Close();
            */
        }

       
    }
}
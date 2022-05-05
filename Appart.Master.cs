using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;

namespace Apartment_Manager
{
    public partial class Appart : System.Web.UI.MasterPage
    {
            protected void Page_Load(object sender, EventArgs e)
            {

                try
                {
                    if ((string)Session["role"] == (" "))

                    {
                        //User link buttons
                        
  
                        hellouser.Visible = false;
                        



                        //Admin links
                        LinkButton6.Visible = true;//Admin link btn
                        LinkButton12.Visible = false;//Customer Management link btn




                    }
                    else if ((string)Session["role"] == ("user"))
                    {
                        //User link buttons
                        
                        
                        hellouser.Visible = true;
                        
                        hellouser.Text = "Hello" + Session["Name"].ToString();

                        //Admin Link Buttons
                        LinkButton6.Visible = false;//Admin link btn
                        LinkButton12.Visible = false;//Customer Management link btn
                       
                    }
                    else if ((string)Session["role"] == ("admin"))
                    {
                        //User link buttons
                        
                        
                        hellouser.Visible = true;
                        
                        hellouser.Text = "Hello Admin";

                        //Admin Link Buttons 
                        LinkButton6.Visible = false;//Admin link btn
                        LinkButton12.Visible = true;//Customer Management link btn
                        
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }



            }

            protected void LinkButton6_Click(object sender, EventArgs e)
            {
                Response.Redirect("Adminlogin.aspx");
            }

            protected void LinkButton12_Click(object sender, EventArgs e)
            {
                Response.Redirect("customerManagement.aspx");
            }

            protected void LinkButton4_Click(object sender, EventArgs e)
            {
                Response.Redirect("Login.aspx");
            }

            protected void LinkButton1_Click(object sender, EventArgs e)
            {
                Response.Redirect("Register.aspx");
            }

            protected void LinkButton3_Click(object sender, EventArgs e)
            {
                Response.Redirect("customerProfile.aspx");
            }



            protected void LinkButton5_Click(object sender, EventArgs e)
            {
                Response.Redirect("Login.aspx");
            }

        }
    
}
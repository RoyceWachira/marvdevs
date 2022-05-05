using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Apartment_Manager
{
    public partial class AdminDash : System.Web.UI.Page
    {
        void NoLandlords()
        {
            AppartmentTableAdapters.numberoflandlords pd = new AppartmentTableAdapters.numberoflandlords();
            DataTable dt = new DataTable();
            dt = pd.GetData(Convert.ToString(Session["userName"]));
            if (dt.Rows.Count >= 1)
            {
                lblNoLandlords.Text = dt.Rows[0]["admin_name"].ToString();
            }
            else
            {
                lblNoLandlords.Text = "0";
            }
        }


        void PopulateTable()
        {
            AppartmentTableAdapters.gridview pt = new AppartmentTableAdapters.gridview();
            DataTable dt = new DataTable();
            dt = pt.GetData(Convert.ToString(Session["userName"]));

            if (dt.Rows.Count > 0)
            {
                TenantDetails.DataSource = dt;
                TenantDetails.DataBind();

            }
            else
            {
                dt.Rows.Add(dt.NewRow());
                TenantDetails.DataSource = dt;
                TenantDetails.DataBind();
                TenantDetails.Rows[0].Cells.Clear();
                TenantDetails.Rows[0].Cells.Add(new TableCell());
                TenantDetails.Rows[0].Cells[0].ColumnSpan = dt.Columns.Count;
                TenantDetails.Rows[0].Cells[0].Text = "No Data Found --!";
                TenantDetails.Rows[0].Cells[0].HorizontalAlign = HorizontalAlign.Center;
            }

        }

        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                if (Session["userName"] == null)
                {
                    Response.Redirect("~/Adminlogin.aspx");
                }
                else
                {
                    NoLandlords();
                    
                    if (!IsPostBack)
                    {
                        PopulateTable();
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }

        }



        protected void btnSearch_Click(object sender, EventArgs e)
        {
            var searchText = Server.UrlEncode(txtSearch.Text); // URL encode in case of special characters
            Response.Redirect("~/Results.aspx?srch=" + searchText);
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Adminlogin.aspx");
        }

        protected void btnPayments_Click(object sender, EventArgs e)
        {
            Response.Redirect("Payments.aspx");
        }

        protected void btnTenants_Click(object sender, EventArgs e)
        {
            Response.Redirect("Results.aspx");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ZZ_Fashion.LoginPages.SalesPersonnel
{
    public partial class ViewCustomers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                displayCustomers();
            }

        }
        protected void displayCustomers ()
        {
            string strconn = ConfigurationManager.ConnectionStrings["ZZFashionCRMConnectionString"].ToString();

            SqlConnection conn = new SqlConnection(strconn);

            SqlCommand cmd = new SqlCommand("SELECT MemberID, MName, MGender, MBirthDate, MAddress, MCountry, MTelNo, MEmailAddr FROM Customer", conn);

            SqlDataAdapter dispCus = new SqlDataAdapter(cmd);

            DataSet result = new DataSet();

            conn.Open();

            dispCus.Fill(result, "Customer");

            conn.Close();

            cusList.DataSource = result.Tables["Customer"];

            cusList.DataBind();

            if (result.Tables["Customer"].Rows.Count > 0)
            {
                lblView.Text = result.Tables["Customer"].Rows.Count.ToString();
            }
            else
            {
                lblView.Text = "No Customer Record";
            }
            
        }
    }
}
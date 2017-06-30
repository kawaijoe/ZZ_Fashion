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

        }
        protected void displayCustomers ()
        {
            string strconn = ConfigurationManager.ConnectionStrings["ZZFashionCRM"].ToString();

            SqlConnection conn = new SqlConnection();
        }
    }
}
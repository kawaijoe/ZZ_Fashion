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
    public partial class VoucherCollect : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void voucherCheck(object sender, EventArgs e)
        {
            string strnConn = ConfigurationManager.ConnectionStrings["ZZFashionCRM"].ToString();

            SqlConnection conn = new SqlConnection();

            SqlConnection cmd = new SqlCommand("UPDATE CashVoucher SET Status = 1 WHERE Status = 0", conn);



        }
    }
}
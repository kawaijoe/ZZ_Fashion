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

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string voucher;
            voucher = txtSerialNo.Text;
            CollectVoucher(voucher);
                
        }

        public int CollectVoucher(string cv)
        {
            string strConn = ConfigurationManager.ConnectionStrings["ZZFashionCRMConnectionString"].ToString();
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand("UPDATE CashVoucher SET Status = 1  WHERE VoucherSN = @voucher ", conn);

            cmd.Parameters.AddWithValue("@voucher", cv);

            //lblUpdated.Visible = true;
            conn.Open();

            cmd.ExecuteNonQuery();
            conn.Close();
                  

            return 0;

        }

        protected void cvError_ServerValidate(object source, ServerValidateEventArgs args)
        {
            string strConn = ConfigurationManager.ConnectionStrings["ZZFashionCRMConnectionString"].ToString();
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand command = new SqlCommand("Select * From CashVoucher WHERE VoucherSN = @voucher ", conn);

            command.Parameters.AddWithValue("@voucher", txtSerialNo.Text);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataSet result = new DataSet();

            conn.Open();

            dataAdapter.Fill(result, "Voucher");
            
            conn.Close();

            if (result.Tables["Voucher"].Rows.Count == 0)
            {
                args.IsValid = false;
                
            }
            else
            {
                lblUpdated.Text = "Done!";
                args.IsValid = true;
                
            }
        }
    }
}
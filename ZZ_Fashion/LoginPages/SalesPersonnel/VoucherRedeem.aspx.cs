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
    public partial class VoucherRedeem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Redeem_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                lblUpdated.Text = "";
                string voucher;
                voucher = txtSerialNo.Text;
                int errorCode = redeem(voucher);
                if (errorCode == 0)
                {
                    lblUpdated.Text = "Done!";
                }
                else
                    lblUpdated.Text = "Not Done!";

            }

            

            

        }

        public int redeem(string rd)
        {
            string strConn = ConfigurationManager.ConnectionStrings["ZZFashionCRMConnectionString"].ToString();
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand("UPDATE CashVoucher SET Status = 2 WHERE VoucherSN = @voucher AND DateDiff(year,DateTimeIssued, getDate() ) < 1", conn);

            cmd.Parameters.AddWithValue("voucher", rd);

            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();

            return 0;
            
        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
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
                args.IsValid = true;
        }

        }
    }
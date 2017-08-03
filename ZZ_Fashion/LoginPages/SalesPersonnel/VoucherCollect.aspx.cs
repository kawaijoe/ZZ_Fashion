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
            if (Page.IsValid)
            {
                lblUpdated.Text = "";
                string voucher = ID.Text;
                int errorCode = CollectVoucher(voucher);
                if (errorCode == 0)
                {
                    lblUpdated.Text = "Done!";
                }
                else if (errorCode == -2)
                    lblUpdated.Text = "Not Done!";
            }

                
        }

        public int CollectVoucher(string cv)
        {
            string strConn = ConfigurationManager.ConnectionStrings["ZZFashionCRMConnectionString"].ToString();
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand("UPDATE CashVoucher SET Status = 1, VoucherSN = @voucher WHERE MemberID = @ID", conn);

            cmd.Parameters.AddWithValue("@voucher", cv);
            cmd.Parameters.AddWithValue("@ID", ID.Text);

            //lblUpdated.Visible = true;
            conn.Open();

           int count = cmd.ExecuteNonQuery();
            conn.Close();

            if (count == 1)
            {
                return 0;
            }
            else
                return -2;


        }

        protected void cvError_ServerValidate(object source, ServerValidateEventArgs args)
        {
            string strConn = ConfigurationManager.ConnectionStrings["ZZFashionCRMConnectionString"].ToString();
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand command = new SqlCommand("Select * From CashVoucher WHERE MemberID = @ID", conn);

            command.Parameters.AddWithValue("@ID", ID.Text);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataSet result = new DataSet();

            conn.Open();

            dataAdapter.Fill(result, "Member");
            
            conn.Close();

            if (result.Tables["Member"].Rows.Count == 0)
            {
                args.IsValid = false;
                
            }
            else
            {
                args.IsValid = true;
                
            }
        }
    }
}
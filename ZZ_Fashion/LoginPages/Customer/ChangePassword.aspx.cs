using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZZ_Fashion.LoginPages.Customer.AppCode;
using System.Data.SqlClient;
using System.Configuration;

namespace ZZ_Fashion.LoginPages.Customer
{
    public partial class ChangePassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Page.IsValid){

                CustomerStuff objCustomer = new CustomerStuff();
                objCustomer.PassWord = NewPass.Text;
                objCustomer.MemberID = Session["LoginID"].ToString();

                int errorCode = objCustomer.changePassWord();
                
                if(errorCode == 0)
                {
                    Response.Redirect("UpdateCustomer.aspx");
                }
                else
                {
                    Message.Text = "Update was unsuccessful, did you key in the right details?";
                }
            }
        }

        protected void IncorrectPass_ServerValidate(object source, ServerValidateEventArgs args)
        {
            string stringConnection = ConfigurationManager.ConnectionStrings["ZZFashionCRMConnectionString"].ToString();

            SqlConnection connection = new SqlConnection(stringConnection);

            SqlCommand command = new SqlCommand("SELECT MPassword FROM Customer WHERE MemberID = @MemberID", connection);

            command.Parameters.AddWithValue("@MemberID", Session["LoginID"]);

            connection.Open();

            string tryPassword = command.ExecuteScalar().ToString();

            connection.Close();

            args.IsValid = (args.Value == tryPassword);
        }
    }
}
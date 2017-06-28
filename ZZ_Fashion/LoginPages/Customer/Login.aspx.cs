using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

namespace ZZ_Fashion.LoginPages.Customer
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                // read inputs of Textboxes and Radio buttons in the Login page
                string loginID = txtLoginID.Text.ToLower();
                string password = txtPassword.Text;


                //check database if loginID is correct,
                string stringConnection = ConfigurationManager.ConnectionStrings["ZZFashionCRMConnectionString"].ToString();

                string Command = "SELECT MemberID FROM Customer WHERE MemberID = @Username AND MPassword = @Password;";
                using (SqlConnection myConnection = new SqlConnection(stringConnection))
                {
                    myConnection.Open();
                    using (SqlCommand myCommand = new SqlCommand(Command, myConnection))
                    {
                        myCommand.Parameters.AddWithValue("@Username", loginID);
                        myCommand.Parameters.AddWithValue("@Password", password);
                        if (loginID == "" || password == "")
                        {
                            return;
                        }

                        // executeScalar produces 1 value from the first row and first column of the Query result
                        var ID = myCommand.ExecuteScalar();
                        if (ID != DBNull.Value && ID != null)
                        {
                            Session["LoginID"] = ID.ToString();
                            Response.Redirect("CustomerHomePage.aspx");
                        }
                        else
                        {
                            lblMessage.Text = "Invalid Login Credentials";
                        }

                    }
                    myConnection.Close();
                }

            }
        }
    }
}
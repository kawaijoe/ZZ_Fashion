using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ZZ_Fashion.LoginPages.Customer
{
    public partial class Profile : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack){

                string stringConnection = ConfigurationManager.ConnectionStrings["ZZFashionCRMConnectionString"].ToString();

                SqlConnection connection = new SqlConnection(stringConnection);

                SqlCommand command = new SqlCommand("SELECT * FROM Customer WHERE MemberID = @MemberID", connection);

                command.Parameters.AddWithValue("@MemberID", Session["LoginID"]);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Name.Text = reader[1].ToString();
                    Gender.Text = reader[2].ToString();
                    BirthDate.Text = reader[3].ToString();
                    ResidentialAddr.Text = reader[4].ToString();
                    Country.Text = reader[5].ToString();
                    PhoneNum.Text = reader[6].ToString();
                    EmailAddr.Text = reader[7].ToString();
                }

                connection.Close();

            }

        }

        protected void Edit_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                string StringValues;
                StringValues = "Name=" + Name.Text;
                StringValues += "&Gender=" + Gender.Text;
                StringValues += "&BirthDate=" + BirthDate.Text;
                StringValues += "&ResidentialAddr=" + ResidentialAddr.Text;
                StringValues += "&Country=" + Country.Text;
                StringValues += "&PhoneNum=" + PhoneNum.Text;
                StringValues += "&EmailAddr=" + EmailAddr.Text;

                Server.UrlEncode(StringValues);

                Response.Redirect("UpdateCustomer.aspx?" + StringValues);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace ZZ_Fashion.LoginPages.Customer
{
    public partial class CustomerHomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string stringConnection = ConfigurationManager.ConnectionStrings["ZZFashionCRMConnectionString"].ToString();

            SqlConnection connection = new SqlConnection(stringConnection);

            SqlCommand command = new SqlCommand("SELECT MName,MBirthDate FROM Customer WHERE MemberID = @MemberID", connection);

            command.Parameters.AddWithValue("@MemberID", Session["LoginID"]);

            
            // Values being Extracted from database and given variables
            DateTime Birthday = new DateTime();
            string name = "";


            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                name = reader[0].ToString();
                Birthday = Convert.ToDateTime(reader[1]);
            }

            connection.Close();

            DateTime Today = DateTime.Now;

            if (Today.Month == Birthday.Month)
            {
                BirthdayMessage.Text = "HAPPY BIRTHDAY "+ name +"<br/> Enjoy additional 15% birthday Discount for each purchase in this month.";
            }
        }

    }
}